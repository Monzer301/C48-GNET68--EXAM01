using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Models
{
    internal class FinalExam:Exam
    {
        public FinalExam() : base() { }

        public FinalExam(int time, int numberOfQuestions, Question[] questions) : base(time, numberOfQuestions, questions) { }

        public override void showExam()
        {
            int grade = 0;
            Console.WriteLine("================================");
            Console.WriteLine("          FINAL EXAM");
            Console.WriteLine("================================");
            Console.WriteLine($"Time: {Time} minutes\n");
            Console.WriteLine($"Number Of Questions: {NumberOfQuestions}");

            for (int i = 0; i < Questions.Length; i++)
            {
                Question question = Questions[i];

                Console.WriteLine($"Question {i + 1}");
                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);

                Console.WriteLine();

                for (int j = 0; j < question.AnswerList.Length; j++)
                {
                    Console.WriteLine(question.AnswerList[j]);
                }
                Console.WriteLine();
                int studentAnswer;

                do
                {
                    Console.Write("Your Answer: ");

                } while (!int.TryParse(Console.ReadLine(), out studentAnswer) ||
                         studentAnswer < 1 ||
                         studentAnswer > question.AnswerList.Length);

                Answer selectedAnswer =
                    question.AnswerList[studentAnswer - 1];

                if (selectedAnswer.AnswerId ==
                    question.RightAnswer.AnswerId)
                {
                    grade += question.Mark;
                }

                Console.WriteLine();
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("========== RESULT ==========");

            Console.WriteLine($"Grade: {grade}");

            int totalMarks = 0;

            foreach (Question question in Questions)
            {
                totalMarks += question.Mark;
            }

            Console.WriteLine($"Total Marks: {totalMarks}");

            Console.WriteLine("============================");
        }
    }
}
