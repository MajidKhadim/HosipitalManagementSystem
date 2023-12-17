using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagementSystemAssignment
{
    internal class Ward:IData
    {
        private long wardNo;
        private long patientId;
        private long bedId;
        private string managingDoctor;
        private long patientCount=0;
        public long WardNo {  get { return wardNo; } set {  wardNo = value; } }
        public long PatientId { get {  return patientId; } set {  patientId = value; } }
        public long BedId { get { return bedId; } set {  bedId = value; } }
        public string ManagingDoctor { get {  return managingDoctor; } set {  managingDoctor = value; } }
        public long PatientCount { get {  return patientCount; } set { patientCount = value; } }
     
        public long getId()
        {
            return this.WardNo;
        }
        public void getData()
        {
        getWN:
            Console.WriteLine("Ward No : ");
            try
            {
                this.WardNo = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid No like 21");
                goto getWN;
            };
            Console.Write("Managing Doctor Id : ");

                this.ManagingDoctor = Console.ReadLine();

        }
        public void addPatient()
        {
        getDI:
            Console.Write("Patient Id : ");

            try
            {
                this.PatientId = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid id like 21");
                goto getDI;
            };
        getWN:
            Console.WriteLine("Bed No  : ");
            try
            {
                this.BedId = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid No like 21");
                goto getWN;
            };

            this.PatientCount++;
        }
        public void showData()
        {
            Console.WriteLine($"     {this.WardNo}                  {this.ManagingDoctor}                               {this.PatientCount}");
        }
    }
}
