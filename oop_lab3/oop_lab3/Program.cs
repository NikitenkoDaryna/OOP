using System;

//variant 12
namespace oop_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TableOfStudents students = new TableOfStudents(10);
            students[0] = new Student {Name = "Daryna", Surname = "Nikitenko", ByPatronomic = "Dmitriivna"};
            Console.WriteLine(students[0].Name);
            Console.WriteLine("StudentsCount" + students.StudentsCount);
        }
    }

    class Student
    {
        public string name;

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

        private string surname;
        private string byPatronomic;
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