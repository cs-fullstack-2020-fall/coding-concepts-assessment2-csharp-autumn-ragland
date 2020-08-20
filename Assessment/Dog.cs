using System;
class Dog
{
    public string name;
    public int age;
    public string breed;

    public Dog(string name, int age, string breed)
    {
        this.name = name;
        this.age = age;
        this.breed = breed;
    }
    public void OutputProps()
    {
        Console.WriteLine($"Name : {this.name}\nAge : {this.age}\nBreed : {this.breed}");
    }
}