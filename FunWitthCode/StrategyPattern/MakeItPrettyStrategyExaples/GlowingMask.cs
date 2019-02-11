using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWitthCode.StrategyPattern.MakeItPrettyStrategyExaples
{
    public class GlowingMask : IMakeItPrettyStrateyInterface
    {
        public string MakeItPretty(string input)
        {
            return input + string.Format(" -and it is pretty with its {0}", nameof(GlowingMask));
        }
    }
}
