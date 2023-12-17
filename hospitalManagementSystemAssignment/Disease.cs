using System;

namespace hospitalManagementSystemAssignment
{
    internal class Disease : IData
    {
        private long id;
        private string name;
        private string symptoms;
        private string treatment;

        public long ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Symptoms { get { return symptoms; } set { symptoms = value; } }
        public string Treatment { get { return treatment; } set { treatment = value; } }

        public Disease()
        {
        }

        public Disease(long id, string name, string symptoms, string treatment)
        {
            this.ID = id;
            this.Name = name;
            this.Symptoms = symptoms;
            this.Treatment = treatment;
        }

        public void getData()
        {
        getId:
            Console.WriteLine("Disease ID : ");
            try
            {
                this.ID = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid id like 21");
                goto getId;
            }

            Console.Write("Disease Name  :  ");
            this.Name = Console.ReadLine();

            Console.Write("Symptoms :  ");
            this.Symptoms = Console.ReadLine();

            Console.Write("Treatment :  ");
            this.Treatment = Console.ReadLine();
        }

        public long getId()
        {
            return this.ID;
        }

        public void showData()
        {
            Console.WriteLine($"         {this.ID}            {this.Name}            {this.Symptoms}              {this.Treatment}");
        }
    }
}
