using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Models
{
    abstract class Question : IComparable, ICloneable
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark{ get; set; }

        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        protected Question()
        {
            Header = "undefined";
            Body = "undefined";
            Mark = 0;
            AnswerList = new Answer[0];
            RightAnswer = new Answer();
        }

        protected Question(string header, string body, int mark, Answer[] answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answers;
            RightAnswer = rightAnswer;
        }

        public abstract object Clone();

        public int CompareTo(object? obj)
        {
            if (obj is Question other)
            {
                return Mark.CompareTo(other.Mark);
            }

            return 1;
        }
        public override string ToString()
        {
            return $"{Header}: {Body} - Mark: {Mark}";
        }

    }
}
