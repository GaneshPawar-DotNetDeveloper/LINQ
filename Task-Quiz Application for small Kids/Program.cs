using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Question> questions = new List<Question>
        {
            new Question("What is the capital of France?", new[] { "A) Berlin", "B) London", "C) Paris", "D) Madrid" }, 'C'),
            new Question("What is 2 + 2?", new[] { "A) 3", "B) 4", "C) 5", "D) 6" }, 'B'),
            new Question("What color is the sky?", new[] { "A) Blue", "B) Green", "C) Red", "D) Yellow" }, 'A'),
            new Question("What is the largest mammal?", new[] { "A) Elephant", "B) Blue Whale", "C) Shark", "D) Giraffe" }, 'B'),
            new Question("What is the boiling point of water?", new[] { "A) 90°C", "B) 80°C", "C) 100°C", "D) 110°C" }, 'C'),
            new Question("Which planet is known as the Red Planet?", new[] { "A) Earth", "B) Mars", "C) Jupiter", "D) Saturn" }, 'B'),
            new Question("What is the largest ocean?", new[] { "A) Atlantic", "B) Indian", "C) Arctic", "D) Pacific" }, 'D'),
            new Question("What is the main ingredient in bread?", new[] { "A) Sugar", "B) Salt", "C) Flour", "D) Butter" }, 'C'),
            new Question("Which animal is known as the king of the jungle?", new[] { "A) Lion", "B) Tiger", "C) Elephant", "D) Bear" }, 'A'),
            new Question("What is the chemical symbol for water?", new[] { "A) H2O", "B) O2", "C) CO2", "D) HO" }, 'A')
        };

        Random random = new Random();
        List<Question> randomQuestions = questions.OrderBy(q => random.Next()).Take(10).ToList();

        int score = 0;

        foreach (var question in randomQuestions)
        {
            Console.WriteLine(question.Text);
            foreach (var option in question.Options)
            {
                Console.WriteLine(option);
            }

            Console.Write("Your answer: ");
            char answer = Console.ReadLine().ToUpper()[0];

            if (answer == question.CorrectAnswer)
            {
                score++;
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer is {question.CorrectAnswer}\n");
            }
        }

        Console.WriteLine($"You scored {score} out of {randomQuestions.Count}");
    }
}

class Question
{
    public string Text { get; }
    public string[] Options { get; }
    public char CorrectAnswer { get; }

    public Question(string text, string[] options, char correctAnswer)
    {
        Text = text;
        Options = options;
        CorrectAnswer = correctAnswer;
    }
}
