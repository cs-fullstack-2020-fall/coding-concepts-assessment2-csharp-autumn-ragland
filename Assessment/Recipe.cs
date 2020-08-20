using System;
using System.Collections.Generic;
class Recipe
{
    private string name;
    private string description;
    private List<string> ingredients = new List<string>();

    public Recipe()
    {

    }
    public void CreateRecipe()
    {
        Console.Write("Name : ");
        this.name = Console.ReadLine();

        Console.Write("Description : ");
        this.description = Console.ReadLine();

        Console.Write("Ingredient : ");
        string userIngredient = Console.ReadLine();
        while(userIngredient != "done")
        {
            this.ingredients.Add(userIngredient);
            Console.Write("Ingredient : ");
            userIngredient = Console.ReadLine();
        }
    }
    public void OutputProps()
    {
        Console.Write($"Name : {this.name}\nDescription : {this.description}\nIngredients: \n");
        this.ingredients.ForEach(ingredient => Console.WriteLine($"- {ingredient}"));
    }
}