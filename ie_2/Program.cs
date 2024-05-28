using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ai
{
    class Program
    {


        static void Main(string[] args)
        {
            string[] questions = { "привет", "как тебя зовут" };
            string[] answers = { "привет", "Доума ",
            };
            string question = "";

            do
            {
                question = Console.ReadLine();

                for (int i = 0; i < questions.Length; i++)
                {
                    if (questions[i] == question)
                    {
                        Console.WriteLine(answers[i]);

                        break;
                    }
                    else if (i == questions.Length - 1)
                    {
                        Console.WriteLine("Гай знает я не знаю!!!");
                    }

                }


            } while (question != "пока");






        }
    }
}