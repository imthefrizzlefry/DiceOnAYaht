# DiceOnAYaht

We want to create the starts of a little game we are calling Dice on a Yacht. We used to play a lot of geeky dice games, and all we had laying around were 5 8-sided dice. For this start, all we need is a function, that given an array of the 5 dice scores, and a category indicator, will return the score that you would get for that category. 

Here is some pseudo code that we might use to call your program: 

enum Category {Ones, Twos, Threes, Fours, Fives, Sixes, Sevens, Eights, ThreeOfAKind, FourOfAKind, FullHouse, SmallStraight, LargeStraight, AllDifferent, Chance, AllSame};
assert(6, getScore(Twos, {1,2,3,2,2}));

For purposes of this exercise, we ask that you do the following scoring categories at a minimum: 

* Any two of (Ones, Twos, Threes, Fours, Fives, Sixes, Sevens, Eights) 
* SmallStraight 
* AllDifferent 
* AllSame 

Below are how to score each of the categories: 
* Ones, Twos, Threes, Fours, Fives, Sixes, Sevens, Eights: 
 * Sum of all dice that match the title of the category. For example {4,4,4,4,5} scores 16 for fours. 
 * ThreeOfAKind, FourOfAKind, FullHouse, SmallStraight, 

* ThreeOfAKind: 
 * Sum of all dice as long as there are at least three dice that are the same, otherwise zero. For example {1,1,1,2,8} scores 13. 

* FourOfAKind: 
 * Sum of all dice as long as there are at least four dice that are the same, otherwise zero. For example {1,1,1,1,8} scores 12. 

* FullHouse: 
 * If there are three of one kind and two of another score 25, otherwise score zero. For example {1,1,1,8,8} scores 25. 

* SmallStraight: 
 * If there are four dice in sequence score 30, otherwise zero. For example {1,2,3,4,7} scores 30. 

* LargeStraight: 
 * If all five dice fall in sequence score 40, otherwise zero. For example {3,4,5,6,7} scores 40. 

* AllDifferent: 
 * If all five dice have unique values score 40, otherwise zero. For example {1,2,4,6,8} scores 40. 

* Chance: 
 * Sum of all dice. For example {1,2,1,8,8} scores 20. 

* AllSame: 
 * If all five dice have the same value score 50, otherwise zero. For example {1,1,1,1,1} scores 50.
