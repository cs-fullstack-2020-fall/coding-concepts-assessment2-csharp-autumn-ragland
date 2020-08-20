using System;
class SportsTeam
{
    private string teamName;
    private string teamCity;
    private int teamRanking;
    public SportsTeam(string teamName, string teamCity, int teamRanking)
    {
        this.teamName = teamName;
        this.teamCity = teamCity;
        this.teamRanking = teamRanking;
    }
    public void OutputProps()
    {
        Console.WriteLine($"Name : {this.teamName}\nCity : {this.teamCity}\nRanking : {this.teamRanking}");
    }
    public void ChangeRanking()
    {
        Console.Write($"The current ranking is {this.teamRanking}\nNew Ranking : ");
        this.teamRanking = Int16.Parse(Console.ReadLine());
        Console.Write($"The current ranking is now {this.teamRanking}");
    }
}