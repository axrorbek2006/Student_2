using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class Group
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Room { get; set; }
        public int Floor { get; set; }
        private static int maxstudentnum = 24;
        public Student[] students = new Student[maxstudentnum];
        private static int currentStudent = 0;
        private static int NewStudent = 0;
        private static int lastID = -1;
        private int studentcount  = 0;
        

        public Group()
        {

        }

        public Group(int id, string name, int room, int floor)
        {
            Id = id;
            Name = name;
            Room = room;
            Floor = floor;
        }

        public void AddStudent(Student student)
        {
            students[currentStudent] = student;
            currentStudent++;
            studentcount++;
        }

        public void RemoveStudent(int num)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Id == num)
                {
                    students[i] = null;
                    studentcount--;
                    break;
                }
            }
            for (int i = 0; i < students.Length; i++)
            {

                if (students[i] != null)
                {
                    students[NewStudent] = students[i];
                    NewStudent++;
                }

            }

        }

        public int StudentCount()
        {
            if(studentcount <= 0)
            {
                return 0;
            }
            return studentcount;
        }
        public void DisplayList()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].Id != lastID)
                {
                    Console.WriteLine($"{i + 1} - Student -------------------- ");
                    Console.WriteLine();
                    Console.WriteLine($"       ID : {students[i].Id} \n     Name : {students[i].FirstName} \n Lastname : {students[i].LastName}  \n    Group : {students[i].Group} \n   Result : {students[i].Result }");
                    Console.WriteLine();
                    lastID = students[i].Id;
                }
            }
        }
    }
}
