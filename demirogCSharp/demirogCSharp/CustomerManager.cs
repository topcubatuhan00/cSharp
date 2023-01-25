using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demirogCSharp
{
    class CustomerManager
    {
        private string _firstName;
        public string name { get { return "Mr. "+_firstName; } set { _firstName = value; } }
        public int age { get; set; }
        public int salary { get; set; }
        public CustomerManager(string name = null, int age = 0, int salary = 0)
        {
            Console.WriteLine("constructor");
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void getContent()
        {
            Console.WriteLine("name : " + name + "\nage : " + age + "\nsal : " + salary);
        }
    }
}
