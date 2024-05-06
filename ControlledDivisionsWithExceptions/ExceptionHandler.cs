using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlledDivisionsWithExceptions
{
    internal class ExceptionHandler
    {
        public static void HandleException(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            // Implementar registro de errores en dbase | file
        }
    }
}
