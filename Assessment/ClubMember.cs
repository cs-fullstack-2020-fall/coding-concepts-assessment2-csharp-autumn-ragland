using System;
class ClubMember
{
    private string name;
    private string role;
    public ClubMember(string name, string role)
    {
        this.name = name;
        this.role = role;
    }
    public void OutputProps()
    {
        Console.WriteLine($"Name : {this.name}\nRole : {this.role}");
    }
}