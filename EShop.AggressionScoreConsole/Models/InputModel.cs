using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggressionScorerConsole
{
    public class InputModel
    {
        [LoadColumn(0), ColumnName("Label")]
        public bool IsAggressive { get; set; }

        [LoadColumn(1)]
        public string Comment { get; set; }
    }
}
