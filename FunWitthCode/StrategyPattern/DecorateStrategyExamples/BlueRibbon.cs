using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWitthCode.StrategyPattern.DecorateStrategyExamples
{
    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    public class BlueRibbon : DecorateStrategyAbstractClass
    {
        public override string Decorate(string input)
        {
            return input + string.Format(" *decorated by {0}", nameof(BlueRibbon));
        }
    }
}
