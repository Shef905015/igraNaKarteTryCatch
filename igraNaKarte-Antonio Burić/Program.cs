using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace igraNaKarte_Antonio_Burić
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karta; 
            int zbroj = 0;
        start: do{
                try { 
                Console.Write("Unesite brojeve u rasponu od 1 do 13: ");
                karta = Convert.ToInt32(Console.ReadLine());

                
                

                    if (karta >= 1 && karta <= 13)
                    {
                        zbroj += karta;
                    }
                    else
                    {
                        Console.WriteLine("Broj nije u rasponu, pokušajte unesti broj u rasponu od 1 do 13.");
                        goto start;

                    }

                }

                catch (Exception greska)
                {

                    Console.WriteLine("Pogrešan unos, pokušajte ponovno.");
                    Console.WriteLine(greska.Message);


                }
            }while (zbroj < 31);

            if(zbroj == 31)
            {

                Console.WriteLine("Pobjeda!");
                Console.WriteLine("Ukupna vrijednost karata je 31.");
                Console.WriteLine("Zbroj: " + zbroj);
                
            }
            if(zbroj > 31)
            {

                Console.WriteLine("Poraz.");
                Console.WriteLine("Ukupna vrijednost je veća od 31.");
                Console.WriteLine("Zbroj: " + zbroj);

            }

            Console.ReadKey();






        }
    }
}
