using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeExcepciones
{
    class Program
    {

        static void Main(string[] args)
        {
            int  Num;
            double NumCuadrado;
            try
            {
                Console.Write("Ingresa un numero entero para elevar al cuadrado: ");
                Num = int.Parse(Console.ReadLine());
                NumCuadrado = Math.Pow(Num, 2);
                
            }
            catch(FormatException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (OverflowException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(NullReferenceException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
