using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWitthCode.StrategyPattern
{
   public class CompositionWithStrategyPatterns
    {
       public DecorateStrategyAbstractClass decorationStrategy { get; set; }
    public IMakeItPrettyStrateyInterface makingItPrettyStrategy { get; set; }

        public CompositionWithStrategyPatterns()
        {

        }
        
    }
}
