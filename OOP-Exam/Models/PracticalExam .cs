using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Models
{
    internal class PracticalExam : Exam
    {
        public PracticalExam() : base() { }
        public PracticalExam(int time, int numberOfQuestions, Question[] questions) : base(time, numberOfQuestions, questions) { }


        public override void showExam()
        {
            Console.WriteLine("Practical Exam");
            Console.WriteLine($"Time: {Time} minutes\n");

            for (int i = 0; i < Questions.Length; i++)
            {
                Question question = Questions[i];

                Console.WriteLine($"Question {i + 1}:");
                Console.WriteLine(question.Body);
                Console.WriteLine();

                for (int j = 0; j < question.AnswerList.Length; j++)
                {
                    Console.WriteLine(question.AnswerList[j]);
                }
                Console.WriteLine();
                Console.WriteLine($"correct answer: {question.RightAnswer}");
                Console.WriteLine("-----------------------------------");
            }
            Console.WriteLine("Practical Exam Finished.");
            Console.WriteLine("==============================");
        }
    }
}
