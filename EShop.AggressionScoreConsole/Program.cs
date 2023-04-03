using AggressionScorerConsole;
using Microsoft.ML;
using Microsoft.ML.Calibrators;
using Microsoft.ML.Trainers;

Console.WriteLine("Aggression scorer model builder started!");

var mlContext = new MLContext(0);

#region Load Data

var createInputFile = @"Data\preparedInput.tsv";
DataPreparer.CreatePreparedDataFile(createInputFile, true);

IDataView traningDataView = mlContext.Data.LoadFromTextFile<InputModel>(
    path: createInputFile,
    hasHeader: true,
    separatorChar: '\t',
    allowQuoting: true
    );

var inputDataSplit = mlContext.Data.TrainTestSplit(traningDataView, testFraction: 0.2, seed: 0);

#endregion

#region Build Pipeline

var inputDataPrepare = mlContext
    .Transforms
    .Text
    .FeaturizeText("Features", "Comment")
    .Append(mlContext.Transforms.NormalizeMeanVariance("Features"))
    .AppendCacheCheckpoint(mlContext)
    .Fit(inputDataSplit.TrainSet);

var trainer = mlContext
    .BinaryClassification
    .Trainers
    .LbfgsLogisticRegression();

#endregion

#region Train The Model

Console.WriteLine(" -- Start Training -- ");

ITransformer model = trainer.Fit(inputDataPrepare.Transform(inputDataSplit.TrainSet));

#endregion

#region Test The Model

EvaluateModel(mlContext, model, inputDataPrepare.Transform(inputDataSplit.TestSet));

#endregion

#region Save The Model

if (!Directory.Exists("Models"))
    Directory.CreateDirectory("Models");

var modelFile = @"Models\AggressionScoreModel.zip";
mlContext.Model.Save(model, traningDataView.Schema, modelFile);

Console.WriteLine("Main Model Saved!");

var dataPreparePipelineFile = @"Models\DataPreparePipeline.zip";
mlContext.Model.Save(inputDataPrepare, traningDataView.Schema, dataPreparePipelineFile);

Console.WriteLine("Saving Data Prepare Pipeline...");

var retrainedModel = RetrainModel(modelFile, dataPreparePipelineFile);

var completeRetrainedPipeline = inputDataPrepare.Append(retrainedModel);

Console.WriteLine("Saving Retrained Model...");

var retrainModelFile = @"Models\AggressionScoreRetrainedModel.zip";
mlContext.Model.Save(completeRetrainedPipeline, traningDataView.Schema, retrainModelFile);

Console.WriteLine("Retrained Model Saved!");

EvaluateModel(mlContext, model, completeRetrainedPipeline.Transform(inputDataSplit.TestSet));

#endregion

void EvaluateModel(MLContext mlContext, ITransformer trainedModel, IDataView testData)
{
    Console.WriteLine();
    Console.WriteLine("-- Evaluating Binary Classification Model --");
    Console.WriteLine();

    //For Testing The Accuracy Of TrainedModel
    //Acuracy here is the confident of the model of predicting the positivity (should be lower for negative parameters like hate)
    var predictedData = trainedModel.Transform(testData);
    var metrics = mlContext.BinaryClassification.Evaluate(predictedData);
    Console.WriteLine($"Accuracy: {metrics.Accuracy:0.###}");

    //Show Confusion Table for optimizing parameters 
    Console.WriteLine($"Confusion:");
    Console.WriteLine();
    Console.WriteLine(metrics.ConfusionMatrix.GetFormattedConfusionTable());
    Console.WriteLine();

}

ITransformer RetrainModel(string modelFile, string dataPreparePipelineFile)
{
    MLContext retrainMlContext = new MLContext(0);

    ITransformer preTrainedModel = retrainMlContext.Model.Load(modelFile, out _);

    var preTrainedModelParameters =
        ((ISingleFeaturePredictionTransformer<CalibratedModelParametersBase<LinearBinaryModelParameters, PlattCalibrator>>)
        preTrainedModel).Model.SubModel;


    var createRetrainInputFile = @"Data\preparedInput.tsv";
    DataPreparer.CreatePreparedDataFile(createRetrainInputFile, true);

    IDataView reTraningDataView = mlContext.Data.LoadFromTextFile<InputModel>(
    path: createRetrainInputFile,
    hasHeader: true,
    separatorChar: '\t',
    allowQuoting: true
    );

    ITransformer reTrainedData = retrainMlContext.Model.Load(modelFile, out _);

    var newData = reTrainedData.Transform(reTraningDataView);

    var retrainModel = mlContext
        .BinaryClassification
        .Trainers
        .LbfgsLogisticRegression()
        .Fit(newData, preTrainedModelParameters);

    return retrainModel;
}
