using System;
using System.Collections.Generic;

namespace hospitalManagementSystemAssignment
{
    internal class MainClass
    {
        private List<Doctor> doctorsList = new List<Doctor>();
        private List<Patient> patientsList = new List<Patient>();
        private List<Nurse> nurseList = new List<Nurse>();
        private List<Prescription> prescriptionList= new List<Prescription>();
        private List<Appointment> appointmentList = new List<Appointment>();
        private List<Ward> wardsList = new List<Ward>();
        private List<Medicine> medicinesList=new List<Medicine>();
        private List<Disease> diseasesList=new List<Disease>();
        public void MainMenu()
        {
            while (true)
            {
            mainMenu:
                showTitle("main");
                Console.WriteLine("1..... DOCTOR MANAGEMENT        ");
                Console.WriteLine("2..... PATIENT MANAGEMENT       ");
                Console.WriteLine("3..... NURSE MANAGEMENT         ");
                Console.WriteLine("4..... PRESCRIPTION MANAGEMENT  ");
                Console.WriteLine("5..... APPOINTMENT MANAGEMENT   ");
                Console.WriteLine("6..... WARD MANAGEMENT          ");
                Console.WriteLine("7..... MEDICINE MANAGEMENT       ");
                Console.WriteLine("8..... DISEASE MANAGEMENT        ");
                Console.WriteLine("0..... Exit Program             ");
                String choice = Console.ReadLine();
                Console.Clear();
                if (choice == "1")
                {
                    subMenu:
                    showTitle("Doctor");
                    menu();
                    int option=Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            {
                                doctorsList.Add(new Doctor());
                                doctorsList[doctorsList.Count - 1].getData();
                                dataStorageSuccessMsg();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine($"  Doctor Id         Doctor Name         Doctor Age          Doctor Address         Specialization");
                                displayRecords<Doctor>(doctorsList);
                                break;
                            }
                        case 3:
                            {
                                updateRecord<Doctor>(doctorsList);
                                break;
                            }
                        case 4:
                            {
                                deleteRecord<Doctor>(doctorsList);
                                break;
                            }
                        case 5:
                            {
                                searchRecord<Doctor>(doctorsList);
                                break;
                            }
                        case 6:
                            {
                                Console.Clear();
                                goto mainMenu;
                            }
                        default:
                            {
                                Console.WriteLine("Enter a Valid option from Menu");
                                break;
                            }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto subMenu;
                }
                else if (choice == "2")
                {
                    subMenu:
                    showTitle("Patient");
                    menu();
                    int option = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            {
                                patientsList.Add(new Patient());
                                patientsList[patientsList.Count - 1].getData();
                                dataStorageSuccessMsg();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine($"    Patient Id          Patient Name      Patient Age       Patient Address         Disease");
                                displayRecords<Patient>(patientsList);
                                break;
                            }
                        case 3:
                            {
                                updateRecord<Patient>(patientsList);
                                break;
                            }
                        case 4:
                            {
                                deleteRecord<Patient>(patientsList);
                                break;
                            }
                        case 5:
                            {
                                searchRecord<Patient>(patientsList);
                                break;
                            }
                        case 6:
                            {
                                Console.Clear();
                                goto mainMenu;
                            }
                        default:
                            {
                                Console.WriteLine("Enter a Valid option from Menu");
                                break;
                            }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto subMenu;
                }
                else if (choice == "3")
                {
                    subMenu:
                    showTitle("Nurse");
                    menu();
                    int option = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            {
                                nurseList.Add(new Nurse());
                                nurseList[nurseList.Count - 1].getData();
                                dataStorageSuccessMsg();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine($"Nurse Id       Nurse Name     Nurse Age      Nurse Address      Qualification");
                                displayRecords<Nurse>(nurseList);
                                break;
                            }
                        case 3:
                            {
                                updateRecord<Nurse>(nurseList);
                                break;
                            }
                        case 4:
                            {
                                deleteRecord<Nurse>(nurseList);
                                break;
                            }
                        case 5:
                            {
                                searchRecord<Nurse>(nurseList);
                                break;
                            }
                        case 6:
                            {
                                Console.Clear();
                                goto mainMenu;
                            }
                        default:
                            {
                                Console.WriteLine("Enter a Valid option from Menu");
                                break;
                            }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto subMenu;
                }
                else if (choice == "4")
                {
                    subMenu:
                    showTitle("Prescripton");
                    menu();
                    int option = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            {
                                prescriptionList.Add(new Prescription());
                                prescriptionList[prescriptionList.Count - 1].getData();
                                dataStorageSuccessMsg();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine($"Prescription Id       Doctor ID     Patient Id      Prescription Details");
                                displayRecords<Prescription>(prescriptionList);
                                break;
                            }
                        case 3:
                            {
                                updateRecord<Prescription>(prescriptionList);
                                break;
                            }
                        case 4:
                            {
                                deleteRecord<Prescription>(prescriptionList);
                                break;
                            }
                        case 5:
                            {
                                searchRecord<Prescription>(prescriptionList);
                                break;
                            }
                        case 6:
                            {
                                Console.Clear();
                                goto mainMenu;
                            }
                        default:
                            {
                                Console.WriteLine("Enter a Valid option from Menu");
                                break;
                            }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto subMenu;
                }
                else if (choice == "5")
                {
                    subMenu:
                    showTitle("Appointment");
                    menu();
                    int option = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            {
                                appointmentList.Add(new Appointment());
                                appointmentList[appointmentList.Count - 1].getData();
                                dataStorageSuccessMsg();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine($"Appointment Id       Doctor ID     Patient Id      Date           Time");
                                displayRecords<Appointment>(appointmentList);
                                break;
                            }
                        case 3:
                            {
                                updateRecord<Appointment>(appointmentList);
                                break;
                            }
                        case 4:
                            {
                                deleteRecord<Appointment>(appointmentList);
                                break;
                            }
                        case 5:
                            {
                                searchRecord<Appointment>(appointmentList);
                                break;
                            }
                        case 6:
                            {
                                Console.Clear();
                                goto mainMenu;
                            }
                        default:
                            {
                                Console.WriteLine("Enter a Valid option from Menu");
                                break;
                            }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto subMenu;
                }
                else if (choice == "6")
                {
                    subMenu:
                    showTitle("Wards");
                    Console.WriteLine("1====------------ADD WARD----------------------");
                    Console.WriteLine("2====------------ADD Patient to a Ward---------");
                    Console.WriteLine("3====------------DISPLAY WARD DATA-------------");
                    Console.WriteLine("4====------------UPDATE WARD DATA--------------");
                    Console.WriteLine("5====------------REMOVE WARD-------------------");
                    Console.WriteLine("6====------------SEARCH WARD DATA--------------");
                    Console.WriteLine("7====------------MAIN   MENU-------------------");
                    Console.WriteLine("=================ENTER CHOICE:=================");
                    int option = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            {
                                wardsList.Add(new Ward());
                                wardsList[wardsList.Count - 1].getData();
                                dataStorageSuccessMsg();
                                break;
                            }
                        case 2:
                            {
                                int index = getIDandSearchIn<Ward>(wardsList);
                                if (index != -1)
                                {
                                    wardsList[index].addPatient();
                                    Console.WriteLine("\n\n=============================Record Added Successfully========");
                                    Console.WriteLine("-------------------------------------------------------------------------------------");
                                }
                                else
                                {
                                    Console.WriteLine("                         No Ward FOUND WITH THIS ID");
                                    Console.WriteLine("-----------------------------------------------------------------------------------");
                                }
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine($"     Ward No          ManagingDoctor ID              No of Patients in Ward");
                                displayRecords<Ward>(wardsList);
                                break;
                            }
                        case 4:
                            {
                                updateRecord<Ward>(wardsList);
                                break;
                            }
                        case 5:
                            {
                                deleteRecord<Ward>(wardsList);
                                break;
                            }
                        case 6:
                            {
                                searchRecord<Ward>(wardsList);
                                break;
                            }
                        case 7:
                            {
                                goto mainMenu;
                            }
                        default:
                            {
                                Console.WriteLine("Enter a Valid option from Menu");
                                break;
                            }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto subMenu;
                }
                else if (choice == "7")
                {
                subMenu:
                    showTitle("Medicine");
                    menu();
                    int option = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            {
                                medicinesList.Add(new Medicine());
                                medicinesList[medicinesList.Count - 1].getData();
                                dataStorageSuccessMsg();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine($"Medicine Id     Medicine Name     Manufacturer      Price");
                                displayRecords<Medicine>(medicinesList);
                                break;
                            }
                        case 3:
                            {
                                updateRecord<Medicine>(medicinesList);
                                break;
                            }
                        case 4:
                            {
                                deleteRecord<Medicine>(medicinesList);
                                break;
                            }
                        case 5:
                            {
                                searchRecord<Medicine>(medicinesList);
                                break;
                            }
                        case 6:
                            {
                                Console.Clear();
                                goto mainMenu;
                            }
                        default:
                            {
                                Console.WriteLine("Enter a Valid option from Menu");
                                break;
                            }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto subMenu;
                }
                else if (choice == "8")
                {
                subMenu:
                    showTitle("Disease");
                    menu();
                    int option = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            {
                                diseasesList.Add(new Disease());
                                diseasesList[diseasesList.Count - 1].getData();
                                dataStorageSuccessMsg();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine($"Disease Id       Disease Name         Symptoms         Treatment");
                                displayRecords<Disease>(diseasesList);
                                break;
                            }
                        case 3:
                            {
                                updateRecord<Disease>(diseasesList);
                                break;
                            }
                        case 4:
                            {
                                deleteRecord<Disease>(diseasesList);
                                break;
                            }
                        case 5:
                            {
                                searchRecord<Disease>(diseasesList);
                                break;
                            }
                        case 6:
                            {
                                Console.Clear();
                                goto mainMenu;
                            }
                        default:
                            {
                                Console.WriteLine("Enter a Valid option from Menu");
                                break;
                            }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto subMenu;
                }
                else if (choice == "0")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Enter a Valid Option from Menu");
                    Console.ReadKey();
                    Console.Clear();
                    goto mainMenu;
                }
            }
        }

        void deleteRecord<T>(List<T> list) where T : IData
        {
            int index=getIDandSearchIn<T>(list);
            if (index!=-1)
            {
                list[index].showData();
                Console.WriteLine("DO you really want to delete this Record : 1 => yes 0 => No");
                int todelete = Int32.Parse(Console.ReadLine());
                if (todelete == 1)
                {
                    list.RemoveAt(index);
                    Console.WriteLine("\n\n=============================Record Deleted Successfully========");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("                         No Record FOUND WITH THIS No");
                Console.WriteLine("-----------------------------------------------------------------------------------");
            }
        }
        void searchRecord<T>(List<T> list) where T : IData {

            int index = getIDandSearchIn<T>(list);
            if (index != -1)
            {
                list[index].showData();
            }
            else
            {
                Console.WriteLine("                         No Record FOUND WITH THIS No");
                Console.WriteLine("-----------------------------------------------------------------------------------");
            }
        }
        void updateRecord<T>(List<T> list) where T : IData
        {
            int index = getIDandSearchIn<T>(list);
            if (index!=-1)
            {
                list[index].getData();
                Console.WriteLine("\n\n=============================Record Updated Successfully========");
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("                         No Record FOUND WITH THIS No");
                Console.WriteLine("-----------------------------------------------------------------------------------");
            }
        }
        void displayRecords<T>(List<T> list) where T:IData
        {

            for (int i = 0; i < list.Count; i++)
            {
                list[i].showData();
            }
        }
        int getIDandSearchIn<T>(List<T> list) where T : IData
        {
            int id;
        getId:
            Console.WriteLine("Enter Id : ");
            try
            {
                id = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid id : ");
                goto getId;
            }
            return (list.FindIndex(w => w.getId() == id));
        }
        public void menu()
        {
            Console.WriteLine("1====------------ADD RECORD--------------------");
            Console.WriteLine("2====------------DISPLAY RECORD----------------");
            Console.WriteLine("3====------------UPDATE RECORD-----------------");
            Console.WriteLine("4====------------DELETE RECORD-----------------");
            Console.WriteLine("5====------------SEARCH RECORD-----------------");
            Console.WriteLine("6====------------MAIN   MENU-------------------");
            Console.WriteLine("=================ENTER CHOICE:=================");
        }
        public void dataStorageSuccessMsg()
        {
            Console.WriteLine("\n\n=============================Data Stored Successfully========");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }
        public void showTitle(string title)
        {
            if (title == "main")
            {
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||           HOSPITAL MANAGEMENT SYSTEM             ||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
            }
            else if (title == "Doctor")
            {
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||                    DOCTORS                       ||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
            }
            else if (title == "Patient")
            {
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||                    PATIENTS                      ||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
            }
            else if (title == "Nurse")
            {
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||                      NURSES                      ||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
            }
            else if (title == "Appointment" || title == "appointment")
            {
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||                  APPOINTMENTS                    ||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
            }
            else if (title == "Wards")
            {
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||                    WARDS                         ||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
            }
            else if (title == "Prescripton")
            {
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||                   PRESCRIPTIONS                  ||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
            }
            else if (title == "Medicine")
            {
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||                    MEDICINES                    ||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
            }
            else if (title == "Disease")
            {
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||                    DISEASES                     ||");
                Console.WriteLine("                                  ||==================================================||");
                Console.WriteLine("                                  ||==================================================||");
            }
            else
            {
                Console.WriteLine("Not a Suitable Title");
            }
        }

    }
}
