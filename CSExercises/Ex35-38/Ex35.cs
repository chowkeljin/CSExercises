using System;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            int countA = 0, countE = 0, countI = 0, countO = 0, countU = 0;

            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase.Substring(i, 1).Equals("a") || phrase.Substring(i, 1).Equals("A"))
                    countA++;
                else if (phrase.Substring(i, 1).Equals("e") || phrase.Substring(i, 1).Equals("E"))
                    countE++;
                else if (phrase.Substring(i, 1).Equals("i") || phrase.Substring(i, 1).Equals("I"))
                    countI++;
                else if (phrase.Substring(i, 1).Equals("o") || phrase.Substring(i, 1).Equals("O"))
                    countO++;
                else if (phrase.Substring(i, 1).Equals("u") || phrase.Substring(i, 1).Equals("U"))
                    countE++;
                else { }
            }

            Console.WriteLine("Number of a: {0}", countA);
            Console.WriteLine("Number of e: {0}", countE);
            Console.WriteLine("Number of i: {0}", countI);
            Console.WriteLine("Number of o: {0}", countO);
            Console.WriteLine("Number of u: {0}", countU);
        }
    }
}
