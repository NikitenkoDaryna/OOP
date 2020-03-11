using System;

//variant 12
namespace oop_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            TableOfStudents students = new TableOfStudents(10);
            students[0] = new Student {Name = "Daryna", Surname = "Nikitenko", ByPatronomic = "Dmitriivna"};
            students[1] = new Student {Name = "Kseniia", Surname = "Zinkova", ByPatronomic = "Vi"};
            Console.WriteLine(students[0].Name);
            Console.WriteLine(students[1].Surname);
            Console.WriteLine("StudentsCount " + students.StudentsCount);
        }
    }

    class Student
    {
        private string name;
        private string surname;
        private string byPatronomic;
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public string ByPatronomic
        {
            get => byPatronomic;
            set => byPatronomic = value;
        }

        
    }

    class TableOfStudents
    {
        Student[] data;
        private int studentsCount;

        public int StudentsCount
        {
            get => studentsCount;
            set => studentsCount = value;
        }


        public TableOfStudents(int length)
        {
            data = new Student[length];
        }

        public Student this[int index]
        {
            get { return data[index]; }
            set
            {
                studentsCount += 1;
                data[index] = value;
            }
        }
    }
}