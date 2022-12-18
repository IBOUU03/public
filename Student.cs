using System.Drawing;
using System.Net.NetworkInformation;

internal class Student : Person
{
    
    public bool check;
    

    public Student()
    {
        Console.WriteLine("Adinizi daxil edin");
        this.name = Console.ReadLine();
        Console.WriteLine("Soyadinizi daxil edin");
        this.surname = Console.ReadLine();
        

        
        
       
    }  
}

