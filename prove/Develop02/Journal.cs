using System;
using System.Collections.Generic;

public class Journal{

    //Propieties
    public string _name = "";
    //List of Entry
    public List<Entry> _entries = new List<Entry>();
    
    //Methods
    public void Display(){

        //Convert the fist letter of the string _name to capital letter
        Console.WriteLine($"Name: "+char.ToUpper(_name[0]) + _name.Substring(1));

        //exaample: Name: Ezequiel Tartaglia
        Console.WriteLine($"Entries:");

        
        //Display all the jobs(information for each element) in the list _jobs
        foreach (Entry elementEntry in _entries)
        {
         //Display all the information inside the element
         elementEntry.Display();
         
        }
    }

    }