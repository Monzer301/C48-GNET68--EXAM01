using OOP_Exam.Models;

namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject =new Subject(34, "C# Programming");

            Console.WriteLine("================================");
            Console.WriteLine("     EXAMINATION SYSTEM");
            Console.WriteLine("================================");

            Console.WriteLine();

            Console.WriteLine($"Subject ID: {subject.SubjectId}");
            Console.WriteLine($"Subject Name: {subject.SubjectName}");

            Console.WriteLine();

            subject.createExam();

            Console.WriteLine();
            Console.WriteLine("Press any key to start the exam...");

            Console.ReadKey();

            if (subject.Exam != null)
            {
                subject.Exam.showExam();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();

        }
    }
}
