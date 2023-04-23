using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class Student
    {
        
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Group { get; set; }
            public double Result { get; set; }

            public Student(int id, string firstName, string lastName  , double result , string group  )
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Group = group;
                Result = result;
            }

            public Student() 
            { 
             
            }
            // Id ni o'zgartirish 
            public void ChangeValue(int id)
            {
                Id = id;
            }

            // imtixon javoblarini o'zgartieish
            public void ChangeValue(double result)
            {
                Result = result;
            }

            //ismni o'zgartirish
            public void ChangeValue(string firstName)
            {
                FirstName = firstName;
            }

             //ism va familyani o'zgartirish 
            public void ChangeValue(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            //ism , familya va guruh ni o'zgartirish 
            public void ChangeValue(string firstName, string lastName , string group)
            {
                FirstName = firstName;
                LastName = lastName;
                Group = group;
            }

            public void Display()
            {
                Console.WriteLine($"Id: {Id}\nName: {FirstName}\nLastname: {LastName}");
            }
        }
    }

