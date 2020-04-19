using System;

namespace BasketsCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfBranchesPerTree = 12;
            const int applesPerBranch = 5;
            Console.WriteLine("Please insert number of trees");
            int numOfTrres;
            bool isInputANumber = int.TryParse(Console.ReadLine(), out numOfTrres);
            while (!isInputANumber || numOfTrres <= 0)
            {
                Console.WriteLine("You must enter a positive number");
                isInputANumber = int.TryParse(Console.ReadLine(), out numOfTrres);
            }
            var result = CalculateNumberOfBaskets(numOfTrres, numberOfBranchesPerTree, applesPerBranch);
            Console.ReadLine();

        }
        static int CalculateNumberOfBaskets(int numOfTrees,int numOfBranches,int applesOnBranch)
        {
            const int numOfApplesInBasket = 5;
            int totalNumOfApples = numOfTrees * numOfBranches * applesOnBranch;
            double numberOfBasketsNeeded = totalNumOfApples / numOfApplesInBasket;
            char[] digits = numberOfBasketsNeeded.ToString().ToCharArray();
            foreach (var digit in digits)
            {
                if (digit == '.') numberOfBasketsNeeded++;
            }
            var result = (int)numberOfBasketsNeeded;
            return result;
        }
    }
}
