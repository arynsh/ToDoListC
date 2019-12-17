using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList {
    public class Program {
        public static void Main() {
            Console.WriteLine("Welcome to the To Do List");
            
            while (true) {
                Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View/Exit)");
                string userInput1 = Console.ReadLine();
                if (userInput1 == "Add") {
                    Console.WriteLine("Please enter the description for the new item.");
                    string userInput2 = Console.ReadLine();
                    Item item = new Item(userInput2);
                    Console.Write($"{userInput2} has been added to your list. ");
                } 
                else if (userInput1 == "View") 
                {
                    Console.WriteLine("List:");
                    List<Item> result = Item.GetAll();
                    for (int i =0; i < result.Count; i++) {
                        Console.WriteLine($"* {result[i].Description}");
                    }
                    if (result.Count == 0) {
                        Console.WriteLine("There is nothing inside your list.");
                    }
                }
                else if (userInput1 == "Exit") 
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid input");
                }
            }


        }
    }
}
