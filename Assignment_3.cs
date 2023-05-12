using System;

class studet
{
    string Name;
    int Amount;

    studentDetails obj = new studentDetails();

    public string SNAME { 
        get
        { 
            return Name;
        } 
        set
        { 
            Name = value;
        }
    }
    //public int SAMOUNT { get; set; }
    public int SAMOUNT
    {
        get
        {
            return (int)this.Amount;
        }
        set
        {
            this.Amount = value;
            
            if (value < 10000)
            {
               
                obj.notGoForShopping();
            }
            else
            {
                Console.Write(Name+" ");
                obj.goForShopping();
            }
        }
    }
}

class studentDetails
{
    public void goForShopping()
    {
        studet std = new studet();
        Console.WriteLine("{0} You can go for shopping",std.SNAME);
    }
    public void notGoForShopping()
    {
        studet std = new studet();
        Console.WriteLine("{0} You can't go for shopping",std.SNAME);
    }

    public void stdDetaild1()
    {
        bool flag = true;
        string str;
        
        while (flag)
        {
            Console.WriteLine("Enter your name.");
            str = Console.ReadLine();
            if (str == "")
            {
                Console.WriteLine("Please enter a valid name");
                continue;
                
            }
            else
            {
                flag = false;
            }
            studet std = new studet();
            std.SNAME = str;
            //Console.WriteLine(std.SNAME );
        }
    }
    public void stdDetaild2()
    {
        bool flag = true;
        int amount;
        while (flag)
        {
            Console.WriteLine("Enter your Amount.");
            try
            {
                amount = Convert.ToInt32(Console.ReadLine());
                flag = false;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter the valid amount");
                continue;

            }
            //Console.WriteLine(amount);
            studet std = new studet();
            std.SAMOUNT = amount;


            //Console.WriteLine(std.SAMOUNT);
            
        }
    }
}

class result
{
    public static void Main(string[] args)
    {
        studentDetails std = new studentDetails();
        
        bool flag = true;
        while (flag)
        {
            std.stdDetaild1();
            std.stdDetaild2();
            Console.WriteLine("Do you want to cotinue....\n press Y for yes and N for no.");
            
            try
            {
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch != 'Y' && ch != 'y')
                {
                    flag = false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter Y or N ...");
            }
            
        }
    }
}