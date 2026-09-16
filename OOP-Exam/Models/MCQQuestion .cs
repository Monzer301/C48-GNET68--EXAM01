using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Models
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion() : base() { }

        public MCQQuestion(string header, string body, int mark, Answer[] answers, Answer rightAnswer) : base(header, body, mark, answers, rightAnswer) { }


        public override object Clone()
        {
            Answer[] clonedAnswers = new Answer[AnswerList.Length];
            for (int i = 0; i < AnswerList.Length; i++)
            {
                clonedAnswers[i] = (Answer)AnswerList[i].Clone();
            }
            Answer clonedRightAnswer = (Answer)RightAnswer.Clone();

            return new MCQQuestion(Header, Body, Mark, clonedAnswers, clonedRightAnswer);
        }
    }
}
