using System;

namespace ConsoleApp1
{
    public class Student
    {
        private String name;
        private String rollNumber;
        private String email;
        private String phone;

        public Student()
        {
        }

        public Student(string name, string rollNumber, string email, string phone)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.email = email;
            this.phone = phone;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string RollNumber
        {
            get => rollNumber;
            set => rollNumber = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}