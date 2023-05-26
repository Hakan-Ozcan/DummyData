
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<Person> people = GenerateDummyData(10); // 10 kişilik dummy veri oluştur

        // Oluşturulan dummy veriyi yazdır
        foreach (Person person in people)
        {
            Console.WriteLine($"Ad: {person.Name}, Yaş: {person.Age}, E-posta: {person.Email}");
        }

        Console.ReadLine();
    }

    static List<Person> GenerateDummyData(int count)
    {
        List<Person> people = new List<Person>();

        string[] names = { "John", "Jane", "Michael", "Emily", "William", "Olivia", "Daniel", "Sophia" };
        string[] lastNames = { "Smith", "Johnson", "Brown", "Taylor", "Miller", "Davis", "Wilson", "Moore" };
        string[] domains = { "gmail.com", "yahoo.com", "hotmail.com", "outlook.com" };

        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            string name = names[random.Next(names.Length)];
            string lastName = lastNames[random.Next(lastNames.Length)];
            int age = random.Next(18, 65);
            string email = $"{name.ToLower()}.{lastName.ToLower()}@{domains[random.Next(domains.Length)]}";

            Person person = new Person(name, lastName, age, email);
            people.Add(person);
        }

        return people;
    }
}

class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    public Person(string name, string lastName, int age, string email)
    {
        Name = name;
        LastName = lastName;
        Age = age;
        Email = email;
    }
}