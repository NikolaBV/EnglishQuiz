using System;
using System.Collections.Generic;
using System.Linq;

namespace EnglishQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> wordDefinition = new Dictionary<string, string>();
            wordDefinition.Add("flower", "the seed-bearing part of a plant, consisting of reproductive organs that are typically surrounded by a brightly coloured corolla and a green calyx.");
            wordDefinition.Add("tv remote", "used to operate devices such as a television set");
            wordDefinition.Add("donut", "a small fried cake of sweetened dough, typically in the shape of a ball or ring.");
            wordDefinition.Add("meat", "the flesh of an animal");
            wordDefinition.Add("winter", "the coldest season of the year");
            wordDefinition.Add("movie", "a cinema film.");
            wordDefinition.Add("easter", "celebrating the resurrection of Christ");

            int score = 0;
            Menu(wordDefinition, score);
        }


        public static void Menu(Dictionary<string, string> dictionary, int score)
        {
            Console.WriteLine("Click any key to play the game:");
            Console.ReadKey();
            Console.Clear();
            score = GameTurn(dictionary, score);
            Menu(dictionary, score);
        }

        public static int GameTurn(Dictionary<string, string> dictionary, int score)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, dictionary.Count);

            string word = dictionary.Keys.ElementAt(randomIndex);
            string definition = dictionary[word];
            Console.WriteLine("Your score is: " + score);
            Console.WriteLine("What's the definition of:");
            Console.WriteLine(definition);

            Console.Write("Enter your guess: ");
            string guess = Console.ReadLine().Trim().ToLower();

            if (guess == word)
            {
                Console.WriteLine("Correct!");
                score = AfterRound(true, score);
            }
            else
            {
                Console.WriteLine("Incorrect. The correct word is: " + word);
                score = AfterRound(false, score);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            return score;
        }

        public static int AfterRound(bool hasWonRound, int score)
        {
            if (hasWonRound)
            {
                score++;
                return score;
            }
            else
            {
                score = 0;
                return score;
            }
        }
    }
}
