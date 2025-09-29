using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;


namespace CrudProgram
{
 /* public  class JsonCRUDProgram
    {
        private const string FilePath = "data.json";
       // PatientDetails patient = new PatientDetails();
        public List<PatientDetails> LoadData()
        {
            if (!File.Exists(FilePath))
            {
                return new List<PatientDetails>();
            }
            var jsonData = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<PatientDetails>>(jsonData) ?? new List<PatientDetails>();
        }
        public void SaveData(List<PatientDetails> people)
        {
            var jsonData = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData);
        }
        public void CreatePerson(PatientDetails person)
        {
            var people = LoadData();
            people.Add(person);
            SaveData(people);
        }
        public List<PatientDetails> ReadPeople()
        {
            return LoadData();
        }
        public void UpdatePerson(int id, PatientDetails updatedPerson)
        {
            var people = LoadData();
            var person = people.FirstOrDefault(p => p.Id == id);
            if (person != null)
            {
                person.Name = updatedPerson.Name;
                person.Age = updatedPerson.Age;
                SaveData(people);
            }
        }
        public void DeletePerson(int id)
        {
            var people = LoadData();
            var person = people.FirstOrDefault(p => p.Id == id);
            if (person != null)
            {
                people.Remove(person);
                SaveData(people);
            }
        }

    }*/
}
