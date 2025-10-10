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
                string connectionString = "Server=DESKTOP-DDKSO40\\SQLEXPRESS;Database=batch11;User Id=sa;Password=Anaiyaan@123;";
                string sql = $"exec getallpatientdetails";

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
                string connectionString = "Server=DESKTOP-DDKSO40\\SQLEXPRESS;Database=batch11;User Id=sa;Password=Anaiyaan@123;";
                string sql = $"insert into PatientsDetails values('{record.PatientName}', '{record.PatientMobileNumber}', '{record.PatientEmail}')";

                var connection = new SqlConnection(connectionString);
                connection.Open();
                var result = connection.Execute(sql);
                connection.Close();
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

        public void UpdatePatient(NewPatientsDetails record)
        {
            try
            {
                string connectionString = "Server=DESKTOP-DDKSO40\\SQLEXPRESS;Database=batch11;User Id=sa;Password=Anaiyaan@123;";
                string sql = $"UPDATE PatientsDetails SET PatientName = '{record.PatientName}', PatientMobileNumber = '{record.PatientMobileNumber}', PatientEmail = '{record.PatientEmail}' WHERE PatientId = {record.PatientId}";

                var connection = new SqlConnection(connectionString);
                connection.Open();
                var result = connection.Execute(sql);
                connection.Close();
            }
            catch (SqlException )
            {
                throw;
            }
            catch (Exception )
            {
                throw;
            }
        }


        public void DeletePatient(int id)
        {
            try
            {
                string connectionString = "Server=DESKTOP-DDKSO40\\SQLEXPRESS;Database=batch11;User Id=sa;Password=Anaiyaan@123;";
                string sql = $"DELETE FROM PatientsDetails WHERE PatientId = {id}";

                var connection = new SqlConnection(connectionString);
                connection.Open();
                var result = connection.Execute(sql);
                connection.Close();
            }
            catch (SqlException )
            {
                throw;
            }
            catch (Exception )
            {
                throw;
            }
        }


    }

}
    

