using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagementSystemAssignment
{
    internal class Appointment:IData
    {
        private long id;
        private long doctorID;
        private long patientID;
        private string date;
        private string time;
        public long ID { get { return id; } set { id = value; } }
        public long DoctorID { get {  return doctorID; } set {  doctorID = value; } }
        public long PatientID { get { return patientID; } set {  patientID = value; } }
        public string Date { get { return date; } set { date = value; } }
        public string Time { get { return time; } set { time = value; } }
        public Appointment() { }
        public void getData()
        {
        getId:
            Console.WriteLine("Appointment ID : ");
            try
            {
                this.ID = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid id like 21");
                goto getId;
            };
        getDI:
            Console.Write("Doctor Id : ");

            try
            {
                this.DoctorID = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid id like 21");
                goto getDI;
            };

        getPI:
            Console.Write("Patient ID : ");

            try
            {
                this.PatientID = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid id like 21");
                goto getPI;
            };
            Console.WriteLine("Enter Date for which you want to get Appointment");
            this.Date=Console.ReadLine();
            Console.WriteLine("Enter Time at which you want the appointment");
            this.Time=Console.ReadLine();
        }
        public long getId()
        {
            return this.ID;
        }
        public void showData()
        {
            Console.WriteLine($"            {this.ID}            {this.DoctorID}            {this.PatientID}            {this.Date}            {this.Time}");
        }
    }
}
