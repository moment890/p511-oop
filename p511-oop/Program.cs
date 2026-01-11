using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;

namespace p511_oop {
    public class Person {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program {
        static void Main(string[] args) {
            //Person person = new Person {
            //    Name = "John",
            //    Age = 30
            //};

            // Создание JSON
            //string json = JsonSerializer.Serialize(person);
            //Console.WriteLine(json);

            // Преобразование из JSON в объект
            //Person deserialized = JsonSerializer.Deserialize<Person>(json);
            const string URL = "https://jsonplaceholder.org/posts";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            var response = client.GetAsync(URL);
            Console.WriteLine(response.Result);
        }
    }
}
