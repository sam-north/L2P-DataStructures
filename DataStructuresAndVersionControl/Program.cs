using System;
using System.Collections.Generic;

namespace DataStructuresAndVersionControl
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] stringArray = new string[6] { "bibble", "bab", "fuuuuuu", "reeeeee", "mims", "slurp" };
            int[] intArray = new int[6] { 654, 23, 12, 5, 97, 39 };
            Print(stringArray);
            Print(intArray);

            int numberOfPlayers = 2;

            int[] scores = new int[numberOfPlayers];
            scores[0] = 23;
            scores[1] = 677;
            Print(scores);


            string[] players = new string[numberOfPlayers];
            players[0] = "Salm";
            players[1] = "Been";
            Print(players);


            List<string> stringList = new List<string> { "bibble", "bab", "fuuuuuu", "reeeeee", "mims", "slurp" };
            List<int> intList = new List<int> { 654, 23, 12, 5, 97, 39 };
            Print(stringList);
            Print(intList);

            List<string> morePlayers = new List<string>();

            Print(morePlayers);


            List<int> moreScores = new List<int>();

            Print(moreScores);
        }

        private static void Print(List<int> intList)
        {
            for (int i = 0; i < intList.Count; i++)
                Console.WriteLine(intList[i]);
        }

        private static void Print(List<string> stringList)
        {
            foreach (var item in stringList)
                Console.WriteLine(item);
        }

        private static void Print(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
                Console.WriteLine(stringArray[i]);
        }

        private static void Print(int[] intArray)
        {
            foreach (var item in intArray)
                Console.WriteLine(item);
        }
    }
}
