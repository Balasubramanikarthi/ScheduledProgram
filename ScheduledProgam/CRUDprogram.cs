using CrudProgram;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduledProgram
{
   /* internal class CRUDprogram
    {
        List<PatientDetails> patients = new List<PatientDetails>();

      // public JsonCRUDProgram json = new JsonCRUDProgram();

        public string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
        public void ChooseOption()
        {

            //  int choose = Convert.ToInt32(Console.ReadLine()); 
            int choose = 0;
            while (choose <= 6)
            {
                Console.WriteLine();
                Console.WriteLine("Choose The Options ");
                Console.WriteLine();
                Console.WriteLine(" 1.Add PatientDetails ");
                Console.WriteLine();
                Console.WriteLine(" 2.Update Details ");
                Console.WriteLine();
                Console.WriteLine(" 3.Remove Details ");
                Console.WriteLine();
                Console.WriteLine(" 4.Print Details ");
                Console.WriteLine();
                Console.WriteLine(" 5.SearchDetails ");
                Console.WriteLine();
                Console.WriteLine(" 6.Exit ");
                Console.WriteLine();
                Console.WriteLine("Enter The Options Number 1to5 ");
                choose = Convert.ToInt32(Console.ReadLine());


                if (choose == 1)
                {
                    AddPatientDetail();
                }
                else if (choose == 2)
                {
                    UpdateDetails();
                }
                else if (choose == 3)
                {
                    DeleteDetails();
                }
                else if (choose == 4)
                {
                    PrintDetails();
                }
                else if (choose == 5)
                {
                    SearchDetails();
                }
                else if (choose == 6)
                {
                    Console.WriteLine("Exit From The Program ");
                    break;
                }
                else
                {
                    Console.WriteLine("You Are Enter Invalid Option Number,Try Again ! ");
                }

            }

        }
        public void AddPatientDetail()
        {
            Console.WriteLine();
            PatientDetails patient = new PatientDetails();

            Console.WriteLine("Enter The Patient Details ");
            Console.WriteLine();
          //  Console.WriteLine("Enter The Patient Id ");
            //patient.Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Patient Name ");
            patient.Name = Console.ReadLine();
            Console.WriteLine("Enter The Patient Age ");
            patient.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Patient MobileNumber ");
            long mobile = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter The Patient E-mail ");
            string email = Console.ReadLine();
            if (Duplicate(mobile, email))
            {
                Console.WriteLine("This mobile number or email already exists! Patient not added.\n");
                return;
            }
            else
            {
                patient.MobileNumber = mobile;
                patient.Email = email;
            }
            patients.Add(patient);//jsonCRUDProgram 

            PrintDetails();
        

        }
        public void UpdateDetails()
        {

            Console.WriteLine("Which Patient Details You Are Update? Please Enter The Patient Mobile Number ");
            long mobile = Convert.ToInt64(Console.ReadLine());
            for (int i = 0; i < patients.Count; i++)
                if (patients[i].MobileNumber == mobile)
                {
                    Console.WriteLine("Select The Update Options ");
                    Console.WriteLine(" 1 - Update The Name ");
                    Console.WriteLine(" 2 - Update The Age ");
                    //Console.WriteLine(" 3 - Update The MobileNumber ");
                    //Console.WriteLine(" 4 - Update The Name E-Mail ");
                    Console.WriteLine("Enter The above Options Number . ");
                    int update = Convert.ToInt32(Console.ReadLine());
                    if (update == 1)
                    {
                        Console.WriteLine("Enter The Name ");
                        patients[i].Name = Console.ReadLine();
                        Console.WriteLine(" Updated Succesfully. ");
                    }
                    else if (update == 2)
                    {
                        Console.WriteLine("Enter The Age ");
                        patients[i].Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" Updated Succesfully. ");
                    }
                    else
                    {
                        Console.WriteLine("You Are Enter Invalid Option ! ");
                    }

                }
        }
        public void DeleteDetails()
        {
            Console.WriteLine("Which Patients Details Remove?Enter The Patient Mobile Number . ");
            long remove = Convert.ToInt64(Console.ReadLine());
            for (int i = 0; i < patients.Count; i++)
            {
                if (remove == patients[i].MobileNumber)
                {
                    // patients[i].Name.Remove(i);
                    patients.RemoveAt(i);
                    Console.WriteLine();
                    Console.WriteLine(" Removed This Details.");
                }
            }

        }
        public void PrintDetails()
        {
            for (int i = 0; i < patients.Count; i++)
            {

                Console.WriteLine();
              //  Console.WriteLine("Patient Id : " + patients[i].Id);
                Console.WriteLine("Patient Name : " + patients[i].Name);
                Console.WriteLine("Patient Age : " + patients[i].Age);
                Console.WriteLine("Patient MobileNumber : " + patients[i].MobileNumber);
                Console.WriteLine("Patient E-mail : " + patients[i].Email);
            }

        }
        public void SearchDetails()
        {
            Console.WriteLine("Enter the patient MobileNumber to search:");
            long mobile = Convert.ToInt64(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].MobileNumber == mobile)
                {
                    Console.WriteLine();
                  //  Console.WriteLine("Patient Id : " + patients[i].Id);
                    Console.WriteLine("Patient Name : " + patients[i].Name);
                    Console.WriteLine("Patient Age : " + patients[i].Age);
                    Console.WriteLine("Patient MobileNumber : " + patients[i].MobileNumber);
                    Console.WriteLine("Patient E-mail : " + patients[i].Email);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No patient found with the given mobile number.");
            }
            //////////
        }

        public bool Duplicate(long mobile, string email)
        {
            foreach (var patient in patients)
            {
                if (patient.MobileNumber == mobile || patient.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

    }*/
}
