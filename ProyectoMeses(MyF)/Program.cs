using System.Xml.Schema;

namespace ProyectoMeses_MyF_
{
    internal class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Introduce un numero: ");
                string Respuesta = Console.ReadLine();

                int.TryParse(Respuesta, out int Numero);

                MostrarMeses();

                Console.ReadLine();
            }

        }

        static int MostrarMeses() 
        {
            return 0;
        }

        static void Meses(int Numero)
        {
            switch (Numero)
            {
                case 1:
                    string Mes = "Enero";
                    break;

                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opcion invalida :(");
                    break;

            }
        }
    }
}

