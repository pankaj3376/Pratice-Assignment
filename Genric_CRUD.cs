using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;


class personDetails
{
    List<string> persons = new List<string>();
    
    public string addPerson(string name)
    {
        persons.Add(name);
        if (persons.Count > 0)
        {
            Console.WriteLine("{0} added to List succssfully..", name);
            //return name;
        }
        else
        {
            Console.WriteLine("not added");
        }
        return name;
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
            if (!p.Contains(oldname))
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

        if(persons.Count == 0)
        {
            Console.WriteLine("List is empty..");
        }
        
        /*foreach(string p in persons)
        {
            Console.WriteLine(p);
        }*/
    }
}

class input
{
    public void personInput()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Chose Operation from Below options......");
            Console.WriteLine("1 for InsertData...");
            Console.WriteLine("2 for UpdateData...");
            Console.WriteLine("3 for DeleteData...");
            Console.WriteLine("4 for SearchData...");
            Console.WriteLine("5 for DisplayData...\n");

            int i = Convert.ToInt32(Console.ReadLine());
            personDetails obj = new personDetails();
            switch (i)
            {
                case 1:
                    Console.WriteLine("Enter a Name to insert.. ");
                    string str = Console.ReadLine();
                    obj.addPerson(str);
                    break;

                case 2:
                    Console.WriteLine("Enter old input that you want to update ");
                    string oldname = Console.ReadLine();
                    Console.WriteLine("Enter New Name input that you want to update ");
                    string newname = Console.ReadLine();
                    obj.updatePerson(oldname, newname);
                    break;

                case 3:
                    Console.WriteLine("Enter a Name to remove.. ");
                    string strremove = Console.ReadLine();
                    obj.removePerson(strremove);
                    break;

                case 4:
                    Console.WriteLine("Enter a Name to Search.. ");
                    string strsearch = Console.ReadLine();
                    obj.findPerson(strsearch);
                    break;

                case 5:
                    obj.displayPerson();
                    break;

                default:
                    Console.WriteLine("Please enter a valid choice...");
                    break;
            }

            Console.WriteLine("Do you want to continue..\n press \'Y\' or \'N\' ");
            char ch = Convert.ToChar(Console.ReadLine());
            if(!(ch=='y' || ch == 'y'))
            {
                flag= false;
            }
        }
    }
}

class result
{
    public static void Main(string[] args)
    {
        input obj = new input();
        //personDetails obj1 = new personDetails();
        obj.personInput();
        //obj1.displayPerson();
    }
}
