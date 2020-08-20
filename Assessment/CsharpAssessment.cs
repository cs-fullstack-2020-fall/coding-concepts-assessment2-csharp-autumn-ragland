using System;
using System.Collections.Generic;
using System.Linq;
class CsharpAssessment
{
    public void Sanity()
    {
        Console.WriteLine("C# Assessment");
    }
    public void CompareUserNum()
    {
        Console.Write("Enter a number : "); // prompt
        int userNum = Int16.Parse(Console.ReadLine()); // save input
        List<int> numList = new List<int>(){12, 24, 1, 34, 10, 2, 7}; // define list
        // use a for loop to iterate the List and print out all the values that are larger than the user input
        Console.Write("Numbers greater than user number :"); 
        foreach(int num in numList)
        {
            if(num > userNum)
            {
                Console.Write($" {num} ");
            }
        }
        // use a for loop to iterate the List and print out all the values that are smaller than the user input
        Console.Write("Numbers less than user number :");
        foreach(int num in numList)
        {
            if(num < userNum)
            {
                Console.Write($" {num} ");
            }
        }
    }
    public void PromptKindUser()
    {
        Console.Write("Is it better to be rude or kind? : "); // prompt
        string userInput = Console.ReadLine(); // save input
        // Prompt the user with the message, ‘Is it better to be rude or kind to People?’ Keeping prompting the user to enter an answer until they enter the word kind.
        while (userInput != "kind")
        {
            Console.Write("hat’s not the answer I had hoped to hear. Try again: "); // prompt again
            userInput = Console.ReadLine(); // update input
        }
        // Once the user enters kind, print, Now that’s what I wanted to hear!
        Console.Write("Now that's what I want's to hear!");
    }
    public void MergeLists()
    {
         // initial lists of claims/
        List<int> claimsA = new List<int>(){2, 4, 6, 8, 10};
        List<int> claimsB = new List<int>(){1, 3, 5, 7, 9};
        // empty list for merged claims
        List<int> mergedClaim = new List<int>();
        // iterate through claims
        for(int i = 0; i < claimsA.Count ; i++)
        { 
            mergedClaim.Add(claimsA[i]); // add each claims from list one to merge list
            mergedClaim.Add(claimsB[i]); // add each claims from list two to merge list
        }
        // output merged list
        Console.Write("Merged List : ");
        mergedClaim.ForEach(claim => Console.Write($" {claim} "));
    }
    // expects 2 strings and compares them by length
    public bool chk_strings(string strA, string srtB)
    {
        // return true if the first string parameter has more characters than the second string passed into the function
        if(strA.Length > srtB.Length)
        {
            return true;
        } else {
            return false;
        }
    }
    public void OutputLongerString()
    {
        Console.Write("Enter the first string : "); // prompt
        string userStrA = Console.ReadLine(); // save input

        Console.Write("Enter the second string : "); // prompt
        string userStrB = Console.ReadLine(); // save input
        
        // call chk_strings method and pass in user input
        if(chk_strings(userStrA, userStrB))
        {
            Console.Write($"{userStrA} is longer than {userStrB}");
        } else 
        {
            Console.Write($"{userStrA} is NOT longer than {userStrB}");
        }
    }
    public void SportsTeamsMethods()
    {
        SportsTeam teamA = new SportsTeam("Grizzlies", "Memphis", 3); // create instance
        teamA.OutputProps(); // output all props
        teamA.ChangeRanking(); // update ranking
    }
    public void ClubMemberMethods()
    {
        // create club members
        ClubMember member1 = new ClubMember("Alfred", "President");
        ClubMember member2 = new ClubMember("Troy", "Vice President");
        ClubMember member3 = new ClubMember("Albert", "Secretary");
        ClubMember member4 = new ClubMember("Bob", "Treasurer");

        // add club members to list
        List<ClubMember> memberList = new List<ClubMember>(){member1, member2, member3, member4};

        // output number of members
        Console.WriteLine($"Total Club Members : {memberList.Count}");
        // output each members properties 
        memberList.ForEach(member => member.OutputProps());
    }
    public void DogMethods()
    {
        // Create a list of dogs
        List<Dog> dogList = new List<Dog>();
        dogList.Add(new Dog("Fido", 12, "Beagle"));
        dogList.Add(new Dog("Spike", 1, "Mutt"));
        dogList.Add(new Dog("Elvis", 14, "Mutt"));
        dogList.Add(new Dog("Jack", 6, "Sheltie"));
        dogList.Add(new Dog("Milo", 2, "Mutt"));

        dogList.ForEach(dog => dog.OutputProps()); // output each dogs props
        Console.WriteLine($"Oldest dog : {OldestDog(dogList).name}"); // display oldest
        FilterByBreed(dogList); // output filtered list
        OrderDogs(dogList); // output ordered list
        Console.WriteLine($"Average dog age : {AverageAge(dogList)}"); // output average age
    }
    public Dog OldestDog(List<Dog> dogs)
    {
        int maxAge = dogs.Max(dog => dog.age); // LINQ Max
        List<Dog> oldestDog = dogs.Where(dog => dog.age == maxAge).ToList();
        return oldestDog[0];
    }
    public void FilterByBreed(List<Dog> dogs)
    {
        List<Dog> filtered = dogs.Where(dog => dog.breed == "Mutt").ToList(); // LINQ filtered breed
        filtered.ForEach(dog => dog.OutputProps());
    }
    public void OrderDogs(List<Dog> dogs)
    {
        List<Dog> ordered = dogs.OrderBy(dog => dog.breed).OrderBy(dog => dog.age).ToList(); // LINQ ordered by breed and age
        ordered.ForEach(dog => dog.OutputProps());
    }
    public double AverageAge(List<Dog> dogs)
    {
        double averageAge = dogs.Average(dog => dog.age); // LINQ average
        return averageAge;
    }
    public void RecipeMethods()
    {
        Recipe recipe1 = new Recipe(); // new recipe instance
        recipe1.CreateRecipe(); // create recipe
        recipe1.OutputProps(); // output recipe props
    }
}