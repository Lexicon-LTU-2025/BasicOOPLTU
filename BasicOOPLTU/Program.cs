
namespace BasicOOPLTU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FirstPart();
            Vehicle v = new Vehicle("Volvo");
            Console.WriteLine(v.Turn());
            Car c = new Car("BMW", "R39");
            Console.WriteLine(c.Turn());
            Saab s = new Saab();

            //Console.WriteLine(v.Drive(50));
            //Console.WriteLine(c.Drive(55));
            //c.Stop();
            //

            List<IDrivable> vehicles = new List<IDrivable>
            {
                v,
                s,
                c
            };

            foreach(IDrivable vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Drive(50));

                //unsafe cast
                //Saab saab = (Saab)vehicle;

                //Saab saab = vehicle as Saab; 
                //Console.WriteLine(saab.SpecialMethod());
                
                //Saab saab = vehicle as Saab; 
                //if(saab != null)
                //{
                //    Console.WriteLine(saab.SpecialMethod());
                //}

                //if(vehicle is Saab)
                //{
                //    Saab saab = (Saab)vehicle;
                //    Console.WriteLine(saab.SpecialMethod());
                //}
                if(vehicle is Saab castedToSaab)
                {
                    Console.WriteLine(castedToSaab.SpecialMethod());
                }
            }
        }

        private static void FirstPart()
        {
            Person p = new Person();
            p.Name = "Kalle";
            Employee e = new Employee();
            e.Name = "Nisse";
            e.Salary = 25000;
            Admin a = new Admin();
            a.Name = "Lisa";
            a.Salary = 30000;
            a.Department = "IT";

            Employee admin = new Admin();
            Person admin2 = new Admin();
            Admin admin3 = new Admin();

            Do(admin);
            Do(admin2);
            Do(admin3);
            Do(p);
            Do(e);
            //Admin admin2 = new Employee(); 

            List<Person> people = new List<Person>
            {
                p,
                e,
                a,
                admin,
                admin2,
                admin3
            };
        }

        private static void Do(Person person)
        {
            Console.WriteLine(person); 
        }
    }
}
