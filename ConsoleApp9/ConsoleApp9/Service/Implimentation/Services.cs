using ConsoleApp9.Models;
using ConsoleApp9.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Service.Implimentation
{
    internal class Services : IServices
    {
        Hotel hotel = new Hotel();
        public void Create(int no, double price)
        {
            Room room = new Room
            {
                No = no,
                Price = price,
                IsReserved = false


            };
            if (no <= 0 || price <= 0 )
            {
                
            }
            for (int i = 0; i < hotel.Rooms.Length; i++)
            {
                if(hotel.Rooms[i].No == no)
                {
                    Console.WriteLine("Bele nomreli otaq var");
                    return;
                }
            }
            Array.Resize(ref hotel.Rooms, hotel.Rooms.Length + 1);
            hotel.Rooms[hotel.Rooms.Length - 1] = room;

        }

        public Room[] GetAll()
        {
            return hotel.Rooms;
        }

        public void Reserve(int id)
        {
            for (int i = 0; i < hotel.Rooms.Length; i++)
            {
                if (hotel.Rooms[i].id == id)
                {
                    if (hotel.Rooms[i].IsReserved != true)
                    {
                        hotel.Rooms[i].IsReserved = true;
                        Console.WriteLine("Rezerv oldu");
                    }
                    else
                    {
                        Console.WriteLine("Rezerv olunub");
                    }
                    if (hotel.Rooms[i].id != id)
                    {
                        Console.WriteLine("ID yoxdur");
                    }
                }
            }
        }
    }
}
