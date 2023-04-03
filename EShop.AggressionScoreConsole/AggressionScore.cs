using AggressionScorerConsole;
using Microsoft.Extensions.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.AggressionScoreConsole
{
    public class AggressionScore
    {
        private readonly PredictionEnginePool<InputModel, OutputModel> _predictionEnginePool;

        public AggressionScore(PredictionEnginePool<InputModel, OutputModel> predictionEnginePool)
        {
            _predictionEnginePool = predictionEnginePool;
        }

        public OutputModel Predict(string input)
        {
            return _predictionEnginePool.Predict(
                new InputModel { Comment = input }
                );
        }
    }
}
