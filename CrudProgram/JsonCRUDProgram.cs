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
  public  class JsonCRUDProgram
    {
        private const string FilePath = "data.json";
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public List<Person> LoadData()
        {
            if (!File.Exists(FilePath))
            {
                return new List<Person>();
            }
            var jsonData = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Person>>(jsonData) ?? new List<Person>();
        }
        public void SaveData(List<Person> people)
        {
            var jsonData = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData);
        }
        public void CreatePerson(Person person)
        {
            var people = LoadData();
            people.Add(person);
            SaveData(people);
        }
        public List<Person> ReadPeople()
        {
            return LoadData();
        }
        public void UpdatePerson(int id, Person updatedPerson)
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
    }
}
