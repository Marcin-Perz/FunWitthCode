using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWitthCode.ComparingBoxedValueTypes
{
   public class ComapreBoxedValues<T1,T2>
    {
        public object BoxedValue1 { get; private set; }
        public object BoxedValue2 { get; private set; }

        public ComapreBoxedValues(T1 value1, T2 value2)
        {
            BoxedValue1 = (object)value1;
            BoxedValue2 = (object)value2;
        }

        public bool ClassicOperator()
        {
            return BoxedValue1 == BoxedValue2;
        }

        public bool ReplacmentMethod1()
        {
            bool result = BoxedValue1.Equals(BoxedValue2);


            return result;
        }
    }
}
