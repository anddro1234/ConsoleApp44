using ConsoleApp3.models;


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<User> users = new List<User>()
{
    new User(1, "Giorgi oqrosiasvili", 25, "giorgi.g@example.com", "pass123"),
    new User(2, "Nino archvadze", 30, "nino.n@example.com", "secure456"),
    new User(3, "Levan kirmelashvili", 22, "levani.l@example.com", "mypass789"),
    new User(4, "Mariam svelidze", 27, "mariami.m@example.com", "mariam123"),
    new User(5, "Dachi berize", 35, "dachi.d@example.com", "dachiPass5"),
    new User(6, "Tamar shvelidze", 28, "tamari.t@example.com", "tamo2026"),
    new User(7, "Sandro kurdgelasvili", 24, "sandro.s@example.com", "sandro777"),
    new User(8, "Ana macaberize", 29, "ana.a@example.com", "anaSecure8"),
    new User(9, "Irakli macaberidze", 32, "irakli.i@example.com", "irakli999"),
    new User(10, "Sopio oqrosiasvili", 26, "sopio.s@example.com", "sopio1010"),
    new Lecturer(11, "David Professor", 45, "davit.p@uni.ge", "lecpass11", Lecturer.subjebt.Math, 95),
    new Lecturer(12, "Natia Lecturer", 38, "natia.l@uni.ge", "lecpass12", Lecturer.subjebt.English, 90),
    new Student(13, "Gia Teacher", 50, "gia.m@uni.ge", "lecpass13", Student.subjebt.Physic, 88),
    new Lecturer(14, "Maka Philologist", 41, "maka.p@uni.ge", "lecpass14", Lecturer.subjebt.Georgian, 96),
    new Lecturer(15, "Zura Mathematician", 49, "zura.m@uni.ge", "lecpass15", Lecturer.subjebt.Math, 92),
    new Student(16, "Elene English", 36, "elene.i@uni.ge", "lecpass16", Student.subjebt.English, 91),
    new Student(17, "Beka Physicist", 43, "beka.p@uni.ge", "lecpass17", Student.subjebt.Physic, 85),
    new Lecturer(18, "Ketevan Georgian", 39, "ketevan.k@uni.ge", "lecpass18", Lecturer.subjebt.Georgian, 94),
    new Lecturer(19, "Andria Prof", 52, "andria.pr@uni.ge", "lecpass19", Lecturer.subjebt.Math, 98),
    new Student(20, "Salome Lecturer", 37, "salome.l@uni.ge", "lecpass20", Student.subjebt.English, 89)
};


            //foreach (User user in users)
            //{
            //    Console.WriteLine(user.ToString());
            //}


            List<User> user1 = users
                .Where(users => users.age > 40)
                .OrderBy(users => users.age)
                .ToList();
            foreach (User item in user1)
            {

                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("youngest");
            User user2 = users.MinBy(user => user.age);
            Console.WriteLine(user2.ToString());

            Console.WriteLine("oldest");
            User user3 = users.MaxBy(user => user.age);
            Console.WriteLine(user3.ToString());

            Console.WriteLine();
            Console.WriteLine();

            List<Student> useerrss = users.OfType<Student>().ToList();
            foreach (var item in useerrss)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            List<Lecturer> useerrs = users.OfType<Lecturer>().ToList();
            foreach (var item in useerrs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(useerrss.Average(i => i.age));
            Console.WriteLine(useerrs.Average(i => i.age));
            Console.WriteLine(users.Average(i => i.age));


            Console.WriteLine();
            Console.WriteLine();

            List<string> names = users.Select(c => $"{c.Name.Split(' ')[0]} {c.Name.Split(' ')[1][0]} {c.age} ").ToList();

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            List<User> age = users.OrderByDescending(u => u.age).ToList();



            foreach (var item in age)
            {
                Console.WriteLine(item.age);
            }

            List<string>password = users.Select(u => u.password.Length > 8 ? "kargi parolia": "cudi parolia").ToList();

            foreach (var item in password)
            {

            
                     Console.WriteLine(item);
                
              


            }                        
               
          

        }
    }
}
