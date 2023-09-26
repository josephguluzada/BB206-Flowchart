using System;

namespace BB206Algorythm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var n = 150;

            //if(n % 2 == 0)
            //{
            //    Console.WriteLine(n + " ededi cutdur");
            //}
            //else
            //{
            //    Console.WriteLine(n + " ededi cut deyil!");
            //}

            //var m = 19;
            //if(m % 3 == 0)
            //{
            //    Console.WriteLine(m + " ededi 3e bolunur");
            //}
            //else
            //{
            //    Console.WriteLine(m + " ededi 3e bolunmur");
            //}



            //Verilmis N ededinin 3e ve ya 5e bolunib bolunmediyini tapan alqoritm yazin
            //var number = 9;

            //if (number % 3 == 0)
            //{
            //    Console.WriteLine(number + " 3e bolunur");
            //}
            //else if (number % 5 == 0)
            //{
            //    Console.WriteLine(number + " 5e bolunur");
            //}
            //else
            //{
            //    Console.WriteLine(number + " ne 3e ne de 5e bolunmur!");
            //}

            //if (number % 3 == 0 || number % 5 == 0)
            //{
            //    Console.WriteLine("3e ve ya 5e bolunur");
            //}
            //else
            //{
            //    Console.WriteLine("ne 3e ne de 5e bolunmur!");
            //}

            var numberOfWeek = 5;


            switch (numberOfWeek)
            {
                case 1:
                    Console.WriteLine("B.E");
                    break;
                case 2:
                    Console.WriteLine("C.A");
                    break;
                case 3:
                    Console.WriteLine("C");
                    break;
                case 4:
                    Console.WriteLine("Cume A");
                    break;
                case 5:
                    Console.WriteLine("Cume");
                    break;
                case 6:
                    Console.WriteLine("Senbe");
                    break;
                case 7:
                    Console.WriteLine("Bazar");
                    break;
                default:
                    Console.WriteLine("Heftenin bele bir gunu yoxdur");
                    break;
            }


            //if(numberOfWeek == 1) 
            //{
            //    Console.WriteLine("B.E");
            //}
            //else if(numberOfWeek == 2)
            //{
            //    Console.WriteLine("C.E");
            //}
            //else if(numberOfWeek == 3) 
            //{
            //    Console.WriteLine("C");
            //}
            //else if (numberOfWeek == 4)
            //{
            //    Console.WriteLine("Cume A");
            //}
            //else if (numberOfWeek == 5)
            //{
            //    Console.WriteLine("CUme");
            //}
            //else if (numberOfWeek == 6)
            //{
            //    Console.WriteLine("Senbe");
            //}
            //else if( numberOfWeek == 7)
            //{
            //    Console.WriteLine("Bazar");
            //}
            //else
            //{
            //    Console.WriteLine("Heftenin bele gunu yoxdur!");
            //}





        }
    }
}