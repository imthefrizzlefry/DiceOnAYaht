using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceOnAYaht;

namespace DiceOnAYahtTests
{
    [TestClass]
    public class ScoringTests
    {
        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromOnes()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.Ones;
            var testInputScores = new int[] { 1, 1, 2, 3, 4 };

            int expectedOutput = 2;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Negative")]
        public void getScore_ValidateScoreFromOnesWhenZero()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.Ones;
            var testInputScores = new int[] { 3, 4, 2, 3, 4 };

            int expectedOutput = 0;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromTwos()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.Twos;
            var testInputScores = new int[] { 1, 3, 2, 3, 2 };

            int expectedOutput = 4;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromThrees()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.Threes;
            var testInputScores = new int[] { 1, 3, 2, 3, 4 };

            int expectedOutput = 6;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromFours()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.Fours;
            var testInputScores = new int[] { 4, 4, 4, 4, 5 };

            int expectedOutput = 16;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromFives()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.Fives;
            var testInputScores = new int[] { 5, 4, 5, 4, 5 };

            int expectedOutput = 15;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromSixes()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.Sixes;
            var testInputScores = new int[] { 6, 6, 4, 6, 5 };

            int expectedOutput = 18;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromSevens()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.Sevens;
            var testInputScores = new int[] { 6, 7, 4, 7, 7 };

            int expectedOutput = 21;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromEights()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.Eights;
            var testInputScores = new int[] { 8, 6, 8, 8, 5 };

            int expectedOutput = 24;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromThreeOfAKind()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.ThreeOfAKind;
            var testInputScores = new int[] { 1, 1, 1, 2, 8 };

            int expectedOutput = 13;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Negative")]
        public void getScore_ValidateScoreFromThreeOfAKindWhenZero()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.ThreeOfAKind;
            var testInputScores = new int[] { 1, 7, 1, 2, 8 };

            int expectedOutput = 0;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromFourOfAKind()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.FourOfAKind;
            var testInputScores = new int[] { 1, 1, 1, 1, 8 };

            int expectedOutput = 12;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Negative")]
        public void getScore_ValidateScoreFromFourOfAKindWhenZero()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.FourOfAKind;
            var testInputScores = new int[] { 1, 1, 2, 1, 8 };

            int expectedOutput = 0;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromFullHouse()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.FullHouse;
            var testInputScores = new int[] { 1, 1, 1, 8, 8 };

            int expectedOutput = 25;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Negative")]
        public void getScore_ValidateScoreFromFullHouseWhenZero()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.FullHouse;
            var testInputScores = new int[] { 1, 7, 1, 8, 8 };

            int expectedOutput = 0;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromSmallStraight()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.SmallStraight;
            var testInputScores = new int[] { 1, 2, 3, 4, 7 };

            int expectedOutput = 30;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Negative")]
        public void getScore_ValidateScoreFromSmallStraightWhenZero()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.SmallStraight;
            var testInputScores = new int[] { 1, 9, 3, 4, 7 };

            int expectedOutput = 0;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
        
        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromLargeStraight()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.LargeStraight;
            var testInputScores = new int[] { 3, 4, 5, 6, 7 };

            int expectedOutput = 40;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Negative")]
        public void getScore_ValidateScoreFromLargeStraightWhenZero()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.LargeStraight;
            var testInputScores = new int[] { 3, 4, 5, 6, 8 };

            int expectedOutput = 0;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromAllDifferent()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.AllDifferent;
            var testInputScores = new int[] { 1, 2, 4, 6, 8 };

            int expectedOutput = 40;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Negative")]
        public void getScore_ValidateScoreFromAllDifferentWhenZero()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.AllDifferent;
            var testInputScores = new int[] { 8, 2, 4, 6, 8 };

            int expectedOutput = 0;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromChance()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.Chance;
            var testInputScores = new int[] { 1, 2, 1, 8, 8 };

            int expectedOutput = 20;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }        

        [TestMethod]
        [TestCategory("Positive")]
        public void getScore_ValidateScoreFromAllSame()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.AllSame;
            var testInputScores = new int[] { 1, 1, 1, 1, 1 };

            int expectedOutput = 50;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Negative")]
        public void getScore_ValidateScoreFromAllSameWhenZero()
        {

            var testInputScoreCategory = CategoryScore.scoreCategory.AllSame;
            var testInputScores = new int[] { 1, 1, 4, 1, 1 };

            int expectedOutput = 0;

            int actualOutput = CategoryScore.getScore(testInputScoreCategory, testInputScores);

            Assert.AreEqual(expectedOutput, actualOutput);
        }


    }
}
