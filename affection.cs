using System;

namespace DatingProfile
{ 
  class Profile{

    // Fields 
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    // Constructors
    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
    this.name = name;
    this.age = age;
    this.city = city;
    this.country = country;
    this.pronouns = pronouns;
    }

    // Method
    public void SetHobbies(string[] hobbies){
      this.hobbies = hobbies;
    }

    public void ViewProfile()
    {
      string bio = $"Name: {name}\n Age: {age}\n City: {city}\n Country: {country}\n Pronouns: {pronouns} \n";
      Console.WriteLine(bio);
      Console.WriteLine("Hobbies:");
      foreach(string hobby in hobbies)
      {
        Console.WriteLine($"{hobby}");
      }
    }

  }
}

