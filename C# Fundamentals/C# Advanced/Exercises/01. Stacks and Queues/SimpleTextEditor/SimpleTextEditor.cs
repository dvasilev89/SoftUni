using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Stack<string> textStack = new Stack<string>();

            string text = string.Empty;            

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split();
                  

                string command = commands[0];

                if (command == "1")
                {
                    string textToAdd = commands[1];
                    textStack.Push(text);
                    
                    text += textToAdd;

                }
                else if (command == "2")
                {
                    int textToRemove = int.Parse(commands[1]); 
                    
                    textStack.Push(text);

                    text = text.Substring(0, text.Length - textToRemove);                    

                }
                else if (command == "3")
                {
                    int index = int.Parse(commands[1]);                    

                    Console.WriteLine(text[index - 1]);
                }
                else if (command == "4")
                {
                    text = textStack.Pop();
                }
            }            
        }
    }
}
