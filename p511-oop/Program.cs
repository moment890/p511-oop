using p511_oop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop {
    class employee {

        private string fullName;
        private DateTime dateOfBirth;
        private string phoneNumber;
        private string workEmail;
        private string position;
        private string jobDescription;

        public employee() 
        {
        }

        public string GetFullName() => fullName;
        public void SetFullName(string name) => fullName = name;

        public DateTime GetDateOfBirth() => dateOfBirth;
        public void SetDateOfBirth(DateTime date) => dateOfBirth = date;

        public string GetPhoneNumber() => phoneNumber;
        public void SetPhoneNumber(string phone) => phoneNumber = phone;

        public string GetWorkEmail() => workEmail;
        public void SetWorkEmail(string email) => workEmail = email;

        public string GetPosition() => position;
        public void SetPosition(string pos) => position = pos;

        public string GetJobDescription() => jobDescription;
        public void SetJobDescription(string description) => jobDescription = description;

        public void InputData() {
            Console.WriteLine("Введите данные сотрудника:");

            Console.Write("ФИО: ");
            fullName = Console.ReadLine();

            Console.Write("Дата рождения (дд.мм.гггг): ");
            dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Контактный телефон: ");
            phoneNumber = Console.ReadLine();

            Console.Write("Рабочий email: ");
            workEmail = Console.ReadLine();

            Console.Write("Должность: ");
            position = Console.ReadLine();

            Console.Write("Описание обязанностей: ");
            jobDescription = Console.ReadLine();
        }


         public void OutputData() {
            Console.WriteLine("\nИнформация о сотруднике:");
            Console.WriteLine($"ФИО: {fullName}");
            Console.WriteLine($"Дата рождения: {dateOfBirth.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Телефон: {phoneNumber}");
            Console.WriteLine($"Email: {workEmail}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Обязанности: {jobDescription}");
        }
    }

}
internal class Program {
    static void Main(string[] args) {
        employee employee = new employee();
        employee.InputData();
        employee.OutputData();
        Console.ReadKey();
    }
}

