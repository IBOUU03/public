using ConsoleApp9.Models;
using ConsoleApp9.Service.Implimentation;
using ConsoleApp9.Service.Interface;

IServices room = new Services();

int button;


while (true)
{


        Console.WriteLine("1.Otaq yarat");
        Console.WriteLine("2.Otaqlara bax");
        Console.WriteLine("#.Rezerv ele");
        Console.WriteLine("Programi dayandir");


        button = int.Parse(Console.ReadLine());
    if (button == 1)
    {
        Console.Clear();
        Console.WriteLine("Otaq nomresi ve qiymet daxil et: ");
        room.Create(int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
    }
    else if (button == 2)
    {
        Console.Clear();
        Console.WriteLine("Otaqlar:");
        Room[] rooms = room.GetAll();
        foreach (var item in rooms)
        {
            Console.WriteLine(item);
        }
    }
    else if (button == 3)
    {
        Console.Clear();
        Console.WriteLine("Rezerv ucun id daxil et");
        room.Reserve(int.Parse(Console.ReadLine()));
    }
    else if (button == 4)
    {
        return;
    }
    else
    {
        Console.WriteLine("Yazilan butonlardan istifade et");
    }
        
}


