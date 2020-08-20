# C# Assessment 2

### Instructions
Create an initial class called `csharpAssessment`. Answer each question inside of a separate method that you create in the class. Instantiate an instance of your `csharpAssessment` class from `Program.cs`. For each additional class requested create them in a separate file named appropriatley. 

### Problem 1
Ask the user to enter a number. 
Using the provided list of numbers below, use a for loop to iterate the List and print out all the values that are smaller than the user input and print out all the values that are larger than the number entered by the user.

Start by creating a List called `list_of_many_numbers` with these numbers
 ```12, 24, 1, 34, 10, 2, 7```
 
Example Input/Output if the user enters the number 9:
```
The User entered 9
1  2  7 are smaller than 9
12  24  34  10 are larger than 9
```
### Problem 2
Prompt the user with the message, ‘Is it better to be rude or kind to People?’ 
Keeping prompting the user to enter an answer until they enter the word `kind`. 

Each time they enter something other than `kind`, print the message, `That’s not the answer I had hoped to hear. Try again.` and prompt the user again.

Once the user enters `kind`, print, `Now that’s what I wanted to hear!` and exit the program.

### Problem 3
Given 2 lists of claim numbers below, write the code to merge the 2 lists provided to produce a new list by alternating values between the 2 lists. Once the merge has been completed, print the new list of claim numbers (DO NOT just print the array variable!)
```
# Start with these lists (create proper instance though)
list_of_claim_nums_1 = {2, 4, 6, 8, 10}
list_of_claim_nums_2 = {1, 3, 5, 7, 9}
```
Example Output:
```
The newly created list contains:     2  1  4  3  6  5  8  7  10  9
```
### Problem 4
Write a program that allows users to compare words by their length. Implement a method called `chk_strings` that expects 2 strings and compares them by length.
The function should return `true` if the first string parameter has more characters (i.e. longer) than the second string passed into the function, otherwise, the function should return `false`.
DO NOT print the result in the method, print the result using the return value provided by the method.

HINT: `somestring.Length` 

Example Input/Output:
```
Enter the first string: BIRD
Enter the second string: COW

BIRD is longer than COW
```
### Problem 5
Create a `SportsTeam` Class for tracking sports teams. The class should have the properties `team_name_p, team_city, and team_ranking_p`.
The class should have a method to change a Team’s ranking. 
Your program should create a `SportsTeam` instance with an initial ranking of 2.
Print out the class properties.
Your program should change the ranking of the team to 8 using a class method.
Print out the class properties.


Example Output:
```
The Grizzlies are from Memphis and are 2 in the standings.
// Update the rating from 2 to 8 from your code
The Grizzlies are from Memphis and are 8 in the standings.
```
### Problem 6
Create a class called `ClubMember` 
Each club member has a name and a role  
Create `ClubMember` instances for the following people:
```
Alfred - Club President
Troy - Club Vice President
Albert - Club Secretary
Bob - Club Treasurer
```
Add each member instance to a new club_members list that you create.
Write the code needed to loop through the club member list and print the current number of members in the list, then the member’s name and club role, one per line using string templates.

Example Output:
```
There are currently 4 club members in the list!

Club President: Alfred
Club Vice President: Bean
Club Secretary: Albert
Club Treasurer: Bob
```

### Problem 7
Create a new Dog class using the following:

```
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
    }
```

Create 5 Dog instances
```
            // Create a list of dogs
            dogList = new List<Dog>();
            dogList.Add(new Dog("Fido", 12, "Beagle"));
            dogList.Add(new Dog("Spike", 1, "Mutt"));
            dogList.Add(new Dog("Elvis", 14, "Mutt"));
            dogList.Add(new Dog("Jack", 6, "Sheltie"));
            dogList.Add(new Dog("Milo", 2, "Mutt"));
```

Using *LINQ* expressions, perform the requested actions.

1. Add a `listDogs()` method that will print the list of Dogs and their properties in a user friendly way using string templates.
2. Add a method that will print the age of the oldest dog.
3. Add a method that will filter the list of Dogs to only those with breed of 'Mutt' and use your `listDogs()` method to print their details.
4. Add a method that will sort ascending all dogs by `breed` *and* then by `age`. Use your `listDogs()` method to print their details.
5. Add a method that will print the average age of all dogs.

### Problem 8
1. Create a class called `Recipe` with the following properties:
  * Recipe Name (string)
  * Recipe Description (string)
  * Recipe Ingredients (List of strings)
2. When the executed let the user add a recipe
  * Prompt for recipe name, description, and then as many ingredients as they want to add until the user enters `done`
  * When the user finishes entering all ingredients, use string templates to print the recipe to the console
  
Example Output:
```
Recipe Name: Chicken and Dumplings
Recipe Description: A delicious home style favorite! Great comfort food!
Recipe Ingredients:
- Chicken
- Dumplings
- Chicken Broth
- Corn Starch to thicken 
- salt
- pepper
```

