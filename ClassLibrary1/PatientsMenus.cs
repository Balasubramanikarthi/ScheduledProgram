using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class PatientsMenus
   {
        public void Options()
        {
            PatientsRepository repo = new PatientsRepository();

            while (true)
            {
                Console.WriteLine("\n=== PATIENTS MANAGEMENT ===");
                Console.WriteLine("1. Add new patient");
                Console.WriteLine("2. All Patients Details ");
                Console.WriteLine("3. Update patient");
                Console.WriteLine("4. Delete patient");
                Console.WriteLine("5. Exit");
                Console.Write("Select option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var newPatient = new NewPatientsDetails();
                        Console.Write("Enter Name: ");
                        newPatient.PatientName = Console.ReadLine();
                        Console.Write("Enter Mobile: ");
                        newPatient.PatientMobileNumber = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Enter Email: ");
                        newPatient.PatientEmail = Console.ReadLine();

                        repo.AddPatients(newPatient);
                        Console.WriteLine("Patient added.");
                        break;

                    case "2":
                        var patients = repo.GetPatients();
                        foreach (var p in patients)
                        {
                            Console.WriteLine($"ID: {p.PatientId}, Name: {p.PatientName}, Phone: {p.PatientMobileNumber}, Email: {p.PatientEmail}");
                        }
                        break;

                    case "3":
                        var updatePatient = new NewPatientsDetails();
                        Console.Write("Enter Patient ID to update: ");
                        updatePatient.PatientId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Name: ");
                        updatePatient.PatientName = Console.ReadLine();
                        Console.Write("Enter New Mobile: ");
                        updatePatient.PatientMobileNumber = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Enter New Email: ");
                        updatePatient.PatientEmail = Console.ReadLine();

                        repo.UpdatePatient(updatePatient);
                        Console.WriteLine("Patient updated.");
                        break;

                    case "4":
                        Console.Write("Enter Patient ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        repo.DeletePatient(deleteId);
                        Console.WriteLine("Patient deleted.");
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

   }
}
