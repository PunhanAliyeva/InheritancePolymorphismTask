namespace InheritancePolymorphismTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(2,12,4,5,23,78,67);
            foreach (var grade in student.Grades)
            {
                Console.WriteLine(grade);
            }
            
        }
    }
}