namespace Homework;

class Program
{
    static void Main(string[] args)
    {
      //Test base Assignment
    Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
    Console.WriteLine(assignment.GetSummary());

    Console.WriteLine();
    //Test MathAssignment
    MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "1-10");
    Console.WriteLine(mathAssignment.GetSummary());
    Console.WriteLine(mathAssignment.GetHomeworkList());            

    Console.WriteLine();

    //Test WritingAssignment
    WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
    Console.WriteLine(writingAssignment.GetSummary());
    Console.WriteLine(writingAssignment.GetWritingInformation());   

    }
}

