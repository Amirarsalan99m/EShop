using AggressionScorerConsole;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.ML;

namespace EShop.AggressionScoreConsole
{
    public static class AggressionScoreConsoleServiceExtensions
    {
        private static readonly string _modelFile =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Models", "AggressionScoreModel.zip");

        public static void AddAggressionScoreConsolePredictionEnginePool(this IServiceCollection services)
        {
            services.AddPredictionEnginePool<InputModel, OutputModel>()
                .FromFile(filePath: _modelFile, watchForChanges: true);
        }
    }
}