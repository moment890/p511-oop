using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Json;

namespace p511_oop {
    public class UserDto 
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

    }
    public class RedisterDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
   
    internal class Program {
        private static readonly HttpClient _httpClient = new HttpClient() 
        {
            BaseAddress = new Uri("http://localhost:8080")
        };

        static async Task Main(string[] args)
        {
            List < UserDto > users = await _httpClient.GetFromJsonAsync<List<UserDto>>("/api/users");

            if(users is null) 
            {
                Console.WriteLine("пустой лист");
                return;
            }
            foreach (var user in users) {
                Console.WriteLine(user.Username);
            }

            var newUser = new RedisterDto() 
            {
                Username ="Tim",
                Email = "Tim@mail.ru",
                Password = "12345"

            };
            HttpResponseMessage response = await _httpClient.PatchAsJsonAsync("/api/auth/register", newUser);

            RedisterDto created = await response.Content.ReadFromJsonAsync<RedisterDto>();
            Console.WriteLine(created);
        }

    }
}
