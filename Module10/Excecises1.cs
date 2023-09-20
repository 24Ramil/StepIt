using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
     class Swap<T1>
     {
         public void SwapValues(T1 value1, T1 value2)
         {
             Console.WriteLine(value1 + " " + value2);
             T1 value = value1;
             value1 = value2;
             value2 = value;
             Console.WriteLine(value1 + " " + value2);
         }

     }
}
