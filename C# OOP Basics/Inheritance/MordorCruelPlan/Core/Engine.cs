using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MordorCruelPlan.Factories;
using MordorCruelPlan.Foods;
using MordorCruelPlan.Moods;

namespace MordorCruelPlan.Core
{
    public class Engine
    {
        private FoodFactory foodFactory;
        private MoodFactory moodFactory;

        public Engine()
        {
            foodFactory = new FoodFactory();
            moodFactory = new MoodFactory();
        }

        public void Run()
        {
            int points = 0;

            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string type = input[i];

                Food currentFood = foodFactory.CreateFood(type);
                points += currentFood.Happiness;                
            }

            Mood mood = new Mood();

            if (points < -5)
            {
                mood = moodFactory.CreateMood("angry");
            }
            else if (points >= -5 && points <= 0)
            {
                mood = moodFactory.CreateMood("sad");
            }
            else if (points >= 1 && points <= 15)
            {
                mood = moodFactory.CreateMood("happy");
            }
            else if (points > 15)
            {
                mood = moodFactory.CreateMood("javascript");
            }

            Console.WriteLine(points);
            Console.WriteLine(mood.Name);
        }
    }
}
