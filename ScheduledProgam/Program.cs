using System;
using System.Collections.Generic;
using CrudProgram;
using DataAccessLayer;

namespace ScheduledProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //var test = new MessageTransfer();
            //test.SendEmail();

            // List<PatientDetails> details = new List<PatientDetails>();

            JsonCRUDprogram list = new JsonCRUDprogram();
            list.ChooseOption();


            //PatientsRepository patients = new PatientsRepository();
            // patients.GetPatients();

            //PatientsMenus repo = new PatientsMenus();
            //repo.Options();


        }







    }
}






