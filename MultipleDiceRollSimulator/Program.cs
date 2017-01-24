using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MultipleDiceRollSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Stopwatch sw = new Stopwatch();

            Console.Write("Enter amount of flips: ");
            string rollLimitS = Console.ReadLine();
            int rollLimit = Convert.ToInt32(rollLimitS);
            int rollNum = 0, difference = 0;
            int hT;
            double heads = 0, tails = 0;
            double headPerc, tailPerc, percDifference = 0;
            Console.Clear();

            //Console.WriteLine("{0}     {1}", "Heads", "Tails");

            sw.Start();
            
            while (rollNum < rollLimit)
            {
                hT = rand.Next(2);
                
                if (hT == 0)
                {
                    heads++;
                }
                else if (hT == 1)
                {
                    tails++;
                }

                Console.WriteLine("Heads = {0}\nTails = {1}", heads, tails);

                Console.Clear();

                rollNum++;
            }

            sw.Stop();

            headPerc = (heads / rollLimit) * 100;
            tailPerc = (tails / rollLimit) * 100;

            if (heads > tails)
            {
                percDifference = ((heads - tails) / ((rollLimit) / 2)) * 100;
            }
            else if (tails > heads)
            {
                percDifference = ((tails - heads) / ((rollLimit) / 2)) * 100;
            }

            Console.WriteLine("----Final Results----\nHeads = {0} -- {2}%\nTails = {1} -- {3}%", heads, tails, headPerc, tailPerc);
            
            if (heads > tails)
            {
                difference = Convert.ToInt32(heads - tails);
                Console.WriteLine("Difference = {0}", difference);
            }
            else
            {
                difference = Convert.ToInt32(tails - heads);
                Console.WriteLine("Difference = {0}", difference);
            }
            Console.WriteLine("Difference = {0}%", percDifference);

            Console.WriteLine("Time = {0}", sw.Elapsed);

            Console.ReadLine();
        }
    }
}
