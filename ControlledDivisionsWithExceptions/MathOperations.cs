using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlledDivisionsWithExceptions
{
    internal class MathOperations
    {
        public static int division(int dividendo, int divisor)
        {
            if (dividendo == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero");
            }
            return dividendo / divisor;
        }
    }
}
