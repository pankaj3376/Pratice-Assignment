using System;
using System.Collections.Generic;


class personDetails
{
    List<string> persons = new List<string>();
    
    public void addPerson(string name)
    {
        persons.Add(name);
        //return name;
    }
    public void removePerson(string name)
    {
        persons.Remove(name);
        Console.WriteLine("{0} removed from the list.",name);
    }
    public void findPerson(string name)
    {
        foreach (string p in persons)
        {
            if (p.Contains(name))
            {
                Console.WriteLine("{0} exist in this list",name);
                return;
            }
            else
            {
                Console.WriteLine("{0} Doesn't exist in this list", name);
            }
        }
    }
    public void updatePerson(string oldname, string newName)
    {
        foreach (string p in persons)
        {
            if(!p.Contains(oldname))
            {
                Console.WriteLine("{0} User doesn't exist",oldname);
            }
            else
            {
                p.Replace(oldname, newName);
                Console.WriteLine(oldname + " replace with " + newName);
            }
        }
    }
    public void displayPerson()
    {
        foreach(string p in persons)
        {
            Console.WriteLine($"{p}");
        }
    }
}

class input
{
    public void personInput()
    {
        Console.WriteLine("Chose Operation from Below options......");
        Console.WriteLine("1 for InsertData...");
        Console.WriteLine("2 for UpdateData...");
        Console.WriteLine("3 for DeleteData...");
        Console.WriteLine("4 for SearchData...");
        Console.WriteLine("5 for DisplayData...");
    }
}