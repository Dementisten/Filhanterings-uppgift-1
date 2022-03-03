using System;
using System.IO;

namespace Summa_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath=@"C:\Users\Admin\Desktop\Summa Program\Summa.txt";
            StreamReader sr = new StreamReader(filepath);


            string rad;
            int summa = 0;
            int fem = 0;
            while ((rad = sr.ReadLine()) != null ){
                summa += int.Parse(rad);
                if (rad.Contains("5")){
                    fem++;
                }
            }

            Console.WriteLine("Summan är: " + summa);
            Console.WriteLine("Antal femmor: " + fem);
            sr.Close();

        }
    }
}
