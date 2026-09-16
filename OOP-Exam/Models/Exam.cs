using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Models
{
    abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        protected Exam()
        {
            Time = 0;
            NumberOfQuestions = 0;
            Questions = new Question[0];
        }
        protected Exam(int time, int numberOfQuestions, Question[] questions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }
        public abstract void showExam();
    }
}
