using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagementSystemAssignment
{
    internal class Doctor:IData
    {
        private long id;
        private string name;
        private int age;
        private string address;
        private string specialization;

        public long ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Specialization { get { return specialization; } set { specialization = value; } }
        public Doctor() {
        }
        public Doctor(long id,string name,int age,string address,string specialization) { 
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.Specialization = specialization;
        }
        public void getData()
        {
            getId:
            Console.WriteLine("Doctor ID : " ) ;
            try
            {
                this.ID = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid id like 21");
                goto getId;
            };
            
            Console.Write("Doctor Name  :  ");
            this.Name=Console.ReadLine();
            getAge:
            Console.Write("Doctor Age : ");

            try
            {
                this.Age = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine ("Please Enter a Valid age like 21");
                goto getAge;
            };
            
            Console.Write("Doctor Address :  ");
            this.Address = Console.ReadLine();
            Console.WriteLine("Specialization : ");
            this.Specialization=Console.ReadLine();
        }
        public long getId()
        {
            return this.ID;
        }
        public void showData()
        {
            Console.WriteLine($"         {this.ID}            {this.Name}            {this.Age}              {this.Address}                {this.Specialization}");
        }
    }
}
