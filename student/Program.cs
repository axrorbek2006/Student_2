using System.Diagnostics.Metrics;

namespace student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Student student1 = new Student(13, "Axrorbek", "Yuldashboev" , 100 , "C#_G2");

            Student student2 = new Student(12, "Anvar", "Narzullayev " , 78.5 ,  "C#_G3");

            Student student3 = new Student(11, "Murod", "Azizev" , 56 ,  "java_F2");

            Student student4 = new Student(14, "Ali", "Alixojayev" , 84 , "C#_G4");

            Group guruh = new Group(1, "telegram", 208 , 2);

            guruh.AddStudent(student1);

            guruh.AddStudent(student2);

            guruh.AddStudent(student3);

            guruh.RemoveStudent(student2.Id);

            guruh.DisplayList();

            Console.WriteLine($"-------------------------");
            Console.WriteLine($" Studentlar soni {guruh.StudentCount()} ta !");
        }
    }
}