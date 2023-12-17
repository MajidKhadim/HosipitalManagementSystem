using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagementSystemAssignment
{
    internal class Patient:IData
    {
        private long id;
        private string name;
        private int age;
        private string address;
        private string disease;

        public long ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Disease { get { return disease; } set { disease = value; } }
        public Patient()
        {
        }
        public Patient(long id, string name, int age, string address, string disease)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.Disease = disease;
        }
        public void getData()
        {
        getId:
            Console.WriteLine("Patient ID : ");
            try
            {
                this.ID = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid id like 21");
                goto getId;
            };

            Console.Write("Patient Name  :  ");
            this.Name = Console.ReadLine();
        getAge:
            Console.Write("Patient Age : ");

            try
            {
                this.Age = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid age like 21");
                goto getAge;
            };

            Console.Write("Patient Address :  ");
            this.Address = Console.ReadLine();
            Console.WriteLine("  Diseases :  ");
            this.Disease = Console.ReadLine();
        }
        public long getId()
        {
            return this.ID;
        }
        public void showData()
        {
            Console.WriteLine($"            {this.ID}           {this.Name}             {this.Age}          {this.Address}          {this.Disease}");
        }
    }
}
