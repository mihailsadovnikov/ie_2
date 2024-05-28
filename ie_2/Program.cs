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
           // string[] questions = { "привет", "как тебя зовут" };
           List<string> questions = new List<string>();
            questions.Add("привет");
            questions.Add("как тебя зовут");

            List<string> answers = new List<string>();
            // string[] answers = { "привет", "Доума ",
            //};
            answers.Add("привет");
            answers.Add("Доума ");


            string question = "\"Доума \"";

            do
            {
                question = Console.ReadLine();

                for (int i = 0; i < questions.Count; i++)
                {
                    if (questions[i] == question)
                    {
                        Console.WriteLine(answers[i]);

                        break;
                    }
                    else if (i == questions.Count - 1)
                    {
                        Console.WriteLine("Гай знает я не знаю!!!");
                        questions.Add(question);
                        string answer = Console.ReadLine();

                        answers.Add(answer);
                        Console.WriteLine("понял");

                    }

                }


            } while (question != "пока");






        }
    }
}