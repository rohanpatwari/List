using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Customr Customer1 = new Customr();
            Customer1.ID = 119;
            Customer1.Name = "Rohan";
            Customer1.Salary = 5000;

            Customr Customer2 = new Customr();
            Customer2.ID = 120;
            Customer2.Name = "Ram";
            Customer2.Salary = 6000;

            Customr Customer3 = new Customr();
            Customer3.ID = 121;
            Customer3.Name = "Ravi";
            Customer3.Salary = 7000;

            List<Customr> Cust = new List<Customr>();
            Cust.Add(Customer1);
            Cust.Add(Customer2);
            Cust.Add(Customer3);

            foreach(Customr c in Cust)
            {

                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
        
            }
            Console.ReadLine();



        }
    }
    public class Customr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
