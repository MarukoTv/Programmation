using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texte = "Mb`qsph`d`ftu`m(gvo";
            int ok = 0;
            string texte2 = "";
            string ok2 = "";
            string ok4 = "";
            int ok3 = 0;
            string texte3 = "";
            string ok6 = "";
            int ok5 = 0;

            for (int i = 0; i < texte.Length; i++)
            {
                ok = Convert.ToInt32(texte[i]);
                ok = ok - 1;
                ok2 = ok2 + Convert.ToChar(ok);


            }
            Console.WriteLine(ok2);




            Console.WriteLine("Enter le texte à coder");
            texte2 = Console.ReadLine();
            for (int i = 0; i < texte2.Length; i++)
            {
                ok3 = Convert.ToInt32(texte2[i]);
                ok3 = ok3 + 1;
                ok4 = ok4 + Convert.ToChar(ok3);


            }
            Console.WriteLine(ok4);

            Console.WriteLine("Entrer le texte à décrypter");
            texte3 = Console.ReadLine();

            for (int i = 0; i < texte3.Length; i++)
            {
                ok5 = Convert.ToInt32(texte3[i]);
                ok5 = ok5 - 1;
                ok6 = ok6 + Convert.ToChar(ok5);


            }
            Console.WriteLine(ok6);



            Console.ReadKey();
        }
    }
}
