using System;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try{
                throw new Exception();
            }
            catch(Exception e)
            {
                throw;
            }
        }
    }
}
