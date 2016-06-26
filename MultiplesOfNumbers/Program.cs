using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipesOfNumbers
{

    public class ProgrammingPuzzles
    {

        public static int multiplesOfXunderTotalValueY(int x, int y, int maxNumber)
        {
            //throw new InvalidOperationException("Waiting to be implemented.");

            int multipeOf = x;
            int totalAmount=0;
            int theMaxNumber = maxNumber; // break after reaching this max number

            HashSet<int> tmp = new HashSet<int>();

	        for (int i = 1; i < 10000000; i++)
	        {
	            //Console.WriteLine(i);
                //Console.WriteLine(multipeOf + " * " + i  + " = " + multipeOf * i);

                totalAmount = multipeOf * i;

                if (totalAmount >= theMaxNumber)
                {
                    break;
                }

                if (totalAmount < theMaxNumber)
                {
                    tmp.Add(totalAmount);
                }
                
            }
            
            //---------------------------------------------

            int multipeOfy = y;
            totalAmount = 0;

            for (int i = 1; i < 10000000; i++)
            {

                totalAmount = multipeOfy * i;

                if (totalAmount >= theMaxNumber)
                {
                    break;
                }

                if (totalAmount < theMaxNumber)
                {
                    tmp.Add(totalAmount);
                }
            }

            return tmp.Sum();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(multiplesOfXunderTotalValueY(3, 5, 1000));
        }
    }

}

