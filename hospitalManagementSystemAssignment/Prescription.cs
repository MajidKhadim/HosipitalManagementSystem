using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagementSystemAssignment
{
    internal class Prescription:IData
    {
        private int prescriptionId;
        private int doctorID;
        private int patientId;
        private string prescriptionDetails;
        public  int PrescriptionId {  get { return prescriptionId; } set { prescriptionId = value; } }
        public int DoctorID { get {  return doctorID; } set {  doctorID = value; } }
        public int PatientId { get { return patientId; } set {  patientId = value; } }
        public string PrescriptionDetails { get {  return prescriptionDetails; } set { prescriptionDetails = value; } }


        public void getData()
        {
        getId:
            Console.WriteLine("Prescription ID : ");
            try
            {
                this.PrescriptionId = Int32.Parse(Console.ReadLine());
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
                this.DoctorID  = Int32.Parse(Console.ReadLine());
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
                this.PatientId = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid id like 21");
                goto getPI;
            };
            Console.WriteLine("Prescription Details : ");
            this.prescriptionDetails = Console.ReadLine();
        }

        public long getId()
        {
            return this.PrescriptionId;
        }
        public void showData()
        {
            Console.WriteLine($"            {this.PrescriptionId}            {this.DoctorID}            {this.PatientId}            {this.prescriptionDetails}");
        }
    }
}
