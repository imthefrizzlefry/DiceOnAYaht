using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceOnAYaht
{
    public class CategoryScore
    {
        public enum scoreCategory { Ones=1, Twos, Threes, Fours, Fives, Sixes, Sevens, Eights, ThreeOfAKind, FourOfAKind, FullHouse, SmallStraight, LargeStraight, AllDifferent, Chance, AllSame };

        public static int getScore(scoreCategory categoryValue, int[] diceScores)
        {
            int finalScore = 0;
            switch(categoryValue)
            {
                #region Ones - Eights
                case scoreCategory.Ones:
                case scoreCategory.Twos:
                case scoreCategory.Threes:
                case scoreCategory.Fours:
                case scoreCategory.Fives:
                case scoreCategory.Sixes:
                case scoreCategory.Sevens:
                case scoreCategory.Eights: // if the value is equal to the integer value of the enum, then add it to the final score
                {
                    finalScore = sumDesiredScores((int)categoryValue, diceScores);
                    break;
                }
                #endregion

                #region Two or three of a kind
                case scoreCategory.ThreeOfAKind:
                case scoreCategory.FourOfAKind:
                {
                                               
                    if(checkForXofAKind((int)categoryValue-6, diceScores)) // use enum to determine 3 or 4
                    {
                        finalScore += sumValuesInArray(diceScores);
                    }
                    break;
                }
                #endregion

                #region Full House
                case scoreCategory.FullHouse:
                {
                    bool fullHouse = false;
                    int firstCount = countDesiredScores(diceScores[0], diceScores);
                    if (firstCount == 2 || firstCount == 3)
                    {
                        int secondCount = countDesiredScores(
                                                        findNextValue(diceScores[0], diceScores), diceScores);

                        if((firstCount == 2 && secondCount == 3) || (firstCount == 3 && secondCount == 2))
                        {
                            fullHouse = true;
                        }
                    }

                    if(fullHouse)
                    {
                        finalScore += 25;
                    }

                    break;
                }
                #endregion


                case scoreCategory.SmallStraight:
                case scoreCategory.LargeStraight:
                    {
                        if(arrayContainsSeries((int)categoryValue-8, diceScores))
                        {
                            finalScore = categoryValue == scoreCategory.SmallStraight ? 30 : 40 ;
                        }
                        break;
                    }

                #region All Different
                case scoreCategory.AllDifferent:
                {
                    bool noDuplicateValues = false;
                    foreach(int value in diceScores)
                    {
                        noDuplicateValues = (sumDesiredScores(value, diceScores) == value); // loop through each value to see if it is only found once
                        
                        if (!noDuplicateValues) { break;} // if a duplicate value is found, end the loop
                    }

                    finalScore = noDuplicateValues ? 40 : 0;
                    break;
                }
                #endregion

                #region Chance
                case scoreCategory.Chance: // simply sum up the values
                {
                        finalScore += sumValuesInArray(diceScores);
                    break;
                }
                #endregion

                #region All Same
                case scoreCategory.AllSame: // the first value in the array should be found 5 times, thus we should get
                {
                    if(sumDesiredScores(diceScores[0], diceScores) == diceScores[0] * 5)
                    {
                        finalScore = 50;
                    }
                    break;
                }
                #endregion
            }
           


            return finalScore;
        }

        private static bool arrayContainsSeries(int seriesLength, int[] diceScores)
        {
            Array.Sort(diceScores);            
            int arrayLength = diceScores.Length;
            int consecutiveCount = 0;

            for(int valIndex = 0; valIndex < arrayLength-1; valIndex++)
            {
                if(diceScores[valIndex]+1 == diceScores[valIndex+1])
                {
                    consecutiveCount += 1;
                }
                else
                {
                    consecutiveCount = 0;
                }
                if(consecutiveCount+1 == seriesLength)
                {
                    return true;
                }
            }

            return false;
        }

        static int sumDesiredScores(int desiredScore, int[] diceScores)
        {
            int returnCount = 0;
            foreach (int score in diceScores)
            {
                // add the value of the score
                returnCount += (score == desiredScore ? score : 0);
            }
            return returnCount;
        }

        static int countDesiredScores(int desiredScore, int[] diceScores)
        {
            int returnCount = 0;
            foreach (int score in diceScores)
            {
                // add the value of the score
                returnCount += (score == desiredScore ? 1 : 0);
            }
            return returnCount;
        }

        static bool checkForXofAKind(int x, int[] diceScores)
        {
            foreach (int value in diceScores)
            {
                if (countDesiredScores(value, diceScores) >= x)
                {
                    return true;
                }
            }

            return false;
        }

        static int sumValuesInArray(int[] diceScores)
        {
            int sum = 0;
            foreach (int value in diceScores)
            {
                sum += value;
            }
            return sum;
        }

        private static int findNextValue(int firstValue, int[] diceScores)
        {
            foreach (int value in diceScores)
            {
                if (value != firstValue)
                {
                    return value;
                }
            }

            return 0;
        }
    }

    
}
