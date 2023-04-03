using AggressionScorerConsole;
using EShop.AggressionScoreConsole;
using EShop.Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Controllers
{
    public class MLController : BaseApiController
    {
        private AggressionScore _aggressionScore;

        public MLController(AggressionScore aggressionScore)
        {
            _aggressionScore = aggressionScore;
        }

        [HttpPost("SubmitComment")]
        public async Task<ActionResult<ActionResult<AggressionPrediction>>> SubmitComment([FromQuery] string comment)
        {
            var classification = _aggressionScore.Predict(comment);
            var commentAggression = new AggressionPrediction
            {
                IsAggressive = classification.Prediction,
                Probability = classification.Probability
            };
            return Ok(  new{ commentAggression });
        }
    }
    public class AggressionPrediction
    {
        public bool IsAggressive { get;set;}
        public float Probability { get; set;}
    }
}
