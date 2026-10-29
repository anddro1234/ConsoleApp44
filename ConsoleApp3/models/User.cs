using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string password { get; private set; }

        public User()
        {

        }
        public User(int id, string name, int age, string email, string password)
        {
            Id = id;
            Name = name;
            this.age = age;
            this.email = email;
            this.password = password;

        }

        public override string ToString()
        {
            return $"[{Id}] ,name :{Name} ,age :{age} ,email :{email}";
        }


    }
}
