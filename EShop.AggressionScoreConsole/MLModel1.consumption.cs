﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace EShop_AggressionScoreConsole
{
    public partial class MLModel1
    {
        /// <summary>
        /// model input class for MLModel1.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"rev_id")]
            public float Rev_id { get; set; }

            [ColumnName(@"comment")]
            public string Comment { get; set; }

            [ColumnName(@"year")]
            public float Year { get; set; }

            [ColumnName(@"logged_in")]
            public bool Logged_in { get; set; }

            [ColumnName(@"ns")]
            public string Ns { get; set; }

            [ColumnName(@"sample")]
            public string Sample { get; set; }

            [ColumnName(@"split")]
            public string Split { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel1.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"rev_id")]
            public float Rev_id { get; set; }

            [ColumnName(@"comment")]
            public float[] Comment { get; set; }

            [ColumnName(@"year")]
            public uint Year { get; set; }

            [ColumnName(@"logged_in")]
            public float[] Logged_in { get; set; }

            [ColumnName(@"ns")]
            public float[] Ns { get; set; }

            [ColumnName(@"sample")]
            public float[] Sample { get; set; }

            [ColumnName(@"split")]
            public float[] Split { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public float PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float[] Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLModel1.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
