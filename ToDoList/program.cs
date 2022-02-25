using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace UserInterface
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to your To Do List!");
      AddOrViewList();
    }
    private static void AddOrViewList()
    {

      Console.WriteLine("Press 'A' to add an item. Press 'V' to view your list. Press 'E' to exit program");
      List<Item> newList = new List<Item> {};
      string stringUserInput = Console.ReadLine();
      if (stringUserInput == "A" || stringUserInput == "a")
      {
        Console.WriteLine("What would you like to add?");
        string description = Console.ReadLine();
        Item newItem = new Item (description);
        AddOrViewList();
      }
      else if (stringUserInput == "V" || stringUserInput == "v" )
      {
        List<Item> result = Item.GetAll();
        foreach(Item items in result)
        {
          Console.WriteLine(items.Description);
        }
        AddOrViewList();
      }
      else if (stringUserInput == "E" || stringUserInput == "e")
      {
        Console.WriteLine("Goodbye!");
      }
      else
      {
        Console.WriteLine("We don't recognize that response... Try agian.");
        AddOrViewList();
      }
    }
    
  }
}