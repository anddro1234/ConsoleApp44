using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.models
{
    internal class Student : User
    {
        public enum subjebt
        {

            Georgian,
            English,
            Math,
            Physic


        }
        public int grade { get; set; }
        public subjebt sagani { get; set; }



        public Student() : base()
        {

        }

        public Student(int id, string name, int age, string email, string password, subjebt sagani, int grade) : base(id, name, age, email, password)
        {
            this.grade = grade;
            this.sagani = sagani;
        }
    }
}
