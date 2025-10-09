using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace DataAccessLayer
{
    public class PatientsRepository

    {

        public List<NewPatientsDetails> GetPatients()
        {
            try
            {
                string connectionString = "server=DESKTOP-DDKSO40\\SQLEXPRESS;Database=batch11;User Id=sa;Password=Anaiyaan@123;";
                string sql = $"select * from PatientsDetails";

                var connection = new SqlConnection(connectionString);
                connection.Open();
                var result = connection.Query<NewPatientsDetails>(sql).ToList();
                connection.Close();

                return result;

            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddPatients(NewPatientsDetails record)
        {
            try
            {
                string connectionString = "Server=DESKTOP-8VD1A1F\\SQLEXPRESS;Database=batch11;User Id=sa;Password=Anaiyaan@123;";
                string sql = $"insert into Patients values('{record.PatientName}', '{record.PatientMobileNumber}', {record.PatientEmail})";

                var connection = new SqlConnection(connectionString);
                connection.Open();
                var result = connection.Execute(sql);
                connection.Close();
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }

}
    

