using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Models
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion() : base() { }

        public TrueFalseQuestion(string header, string body, int mark, Answer[] answers, Answer rightAnswer): base(header, body, mark, answers, rightAnswer) { }

        public override object Clone()
        {
            Answer[] cloneAnswers = new Answer[AnswerList.Length];
            for (int i = 0; i < AnswerList.Length; i++)
            {
                cloneAnswers[i] = (Answer)AnswerList[i].Clone();
            }
            Answer clonedRightAnswer = (Answer)RightAnswer.Clone();

            return new TrueFalseQuestion(Header, Body, Mark, cloneAnswers, clonedRightAnswer);
        }
    }
}
