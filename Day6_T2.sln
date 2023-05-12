using System;
using System.Collections;

class DataEntry
{
    ArrayList obj = new ArrayList();
    public void AddData()
    {
        Console.WriteLine("After Adding Data...");
        obj.Add("Pankaj");
        obj.Add("Deepak");
        /*foreach(var i in  obj)
        {
            obj.Add(i);
        }*/

        foreach (var i in obj)
        {
            Console.WriteLine(i);
        }
    }

    public void RemoveData()
    {
        Console.WriteLine("After removing Data...");
        obj.Remove("Pankaj");
        foreach(var i in obj)
        {
            Console.WriteLine(i);
        }
    }

    public static void Main(string[] args)
    {
        DataEntry obj = new DataEntry();
        obj.AddData();
        obj.RemoveData();
    }
}
