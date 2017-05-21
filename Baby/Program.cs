﻿using System;
using System.Collections.Generic;

namespace Baby
{
    class Program
    {
        static void Main(string[] args)
        {
            var questions = new List<string>()
            { "Why is the sky blue?: ",
              "Why does the moon have a face?: ",
              "Where are the dinosaurs?: "
            };

            var rnd = new Random();

            Console.Write(questions[rnd.Next(questions.Count)]);
            var answer = Console.ReadLine().ToLower();

            while (answer != "just because")
            {
                Console.Write("Why? ");
                answer = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Oh... Okay");
        }
    }
}
