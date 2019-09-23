using System;

namespace BMIkalkulaator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double x;
            double pikkus;
            double kaal;
            int yOB;
            string userName;

        Start:
            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            Console.WriteLine($"Tere, {userName}. Kui vana Te olete?");
            yOB = Int16.Parse(Console.ReadLine());

            if(yOB < 20)
            {
                Console.WriteLine("Paraku annab kalkulaator korrektseid tulemusi vaid vanuse vahemikus 20-60." +
                    "vabandame ebamugavuste pärast!");
                goto Start;
            }

            if(yOB > 60)

            {
                Console.WriteLine("Paraku annab kalkulaator korrektseid tulemusi vaid vanuse vahemikus 20-60." +
                    "vabandame ebamugavuste pärast!");
        goto Start;
            }

            else
            {
                Console.WriteLine("Kui palju Te kaalute? Palun sisestage kaal kg...");
                kaal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kui pikk te olete? Palun sisestage pikkus cm...");
                pikkus = Convert.ToDouble(Console.ReadLine());
                double BMI = x = Math.Round( kaal / Math.Pow(pikkus / 100, 2), 2);
                

                if (x < 18.6)
                {
                    Console.WriteLine($"{userName}, teie kehamassiindeks on {x}. Olete alakaalus." );
        goto Start;
                }

                else if (x > 25)
                        
                {
                    Console.WriteLine($"{userName}, teie kehamassiindeks on {x}. Olete ülekaalus.");
        goto Start;
                }

                else
                {
                    Console.WriteLine($"{userName}, teie kehamassiindeks on {x}. Olete normaalkaalus.");
        goto Start;
                }



            }

        }
    }
}
