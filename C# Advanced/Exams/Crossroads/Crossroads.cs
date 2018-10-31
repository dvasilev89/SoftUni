using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1Crossroads
{
    class Crossroads
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            Queue<char> carsSize = new Queue<char>();

            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            int carPassed = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (input != "green")
                {
                    cars.Enqueue(input);
                    char[] carInChars = input.ToCharArray();

                    for (int i = 0; i < carInChars.Length; i++)
                    {
                        carsSize.Enqueue(carInChars[i]);
                    }
                }
                else
                {
                    int currentCarSize = cars.Peek().Length;

                    for (int i = 0; i < greenLightDuration; i++)
                    {
                        carsSize.Dequeue();

                        if (currentCarSize <= greenLightDuration)
                        {
                            cars.Dequeue();
                            carPassed++;

                            if (cars.Count > 0)
                            {
                                currentCarSize = cars.Peek().Length;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (currentCarSize > greenLightDuration && cars.Count > 0)
                        {
                            for (int j = 0; j < freeWindowDuration; j++)
                            {
                                carsSize.Dequeue();

                                if (currentCarSize <= greenLightDuration + freeWindowDuration)
                                {
                                    cars.Dequeue();
                                    currentCarSize = cars.Peek().Length;
                                    carPassed++;
                                }
                            }
                        }
                    }
                }


            }

            foreach (var item in carsSize)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine(carPassed);
        }
    }
}
