using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderPCGen.Classes
{
    class Dice
    {
        private static readonly Random rand = new Random();

        //Takes in the number of sides and number of die to roll and returns a list of the rolls
        public List<int> Roll(int sides, int numOfDie)
        {
            List<int> rolls = new List<int>();

            for (int i = 0; i < numOfDie; i++)
            {
                rolls.Add(rand.Next(1, sides + 1));
            }
            return rolls;
        }

        //Takes in a list and drops the lowest x int values from the list
        public List<int> DropLowestRoll(List<int> rolls, int numToDrop)
        {
            for (int i = 0; i < numToDrop; i++)
            {
                rolls.RemoveAt(rolls.IndexOf(rolls.Min()));
            }

            return rolls;
        }

        //Returns the sum of all the dies
        public int ClassicRoll(int sides, int numOfDie)
        {
            return Roll(sides, numOfDie).Sum();
        }

        //Returns the sum of the remaining rolls after removing the lowest 'x' int values from list
        public int StandardRoll(int sides, int numOfDie, int numToDrop)
        {
            return DropLowestRoll(Roll(sides, numOfDie), numToDrop).Sum();
        }
    }
}
