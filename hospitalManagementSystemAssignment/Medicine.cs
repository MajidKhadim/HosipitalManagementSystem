using System;

namespace hospitalManagementSystemAssignment
{
    internal class Medicine : IData
    {
        private long id;
        private string name;
        private string manufacturer;
        private double price;

        public long ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public double Price { get { return price; } set { price = value; } }

        public Medicine()
        {
        }

        public Medicine(long id, string name, string manufacturer, double price)
        {
            this.ID = id;
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public void getData()
        {
        getId:
            Console.WriteLine("Medicine ID : ");
            try
            {
                this.ID = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid id like 21");
                goto getId;
            }

            Console.Write("Medicine Name  :  ");
            this.Name = Console.ReadLine();

            Console.Write("Medicine Manufacturer :  ");
            this.Manufacturer = Console.ReadLine();

        getPrice:
            Console.Write("Medicine Price : ");
            try
            {
                this.Price = Double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid price like 10.5");
                goto getPrice;
            }
        }

        public long getId()
        {
            return this.ID;
        }

        public void showData()
        {
            Console.WriteLine($"     {this.ID}            {this.Name}            {this.Manufacturer}             {this.Price}");
        }
    }
}
