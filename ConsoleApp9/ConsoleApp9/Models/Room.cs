using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Models
{
    internal class Room
    {
        private static int _id = 0;
        public readonly int id;
        public int No { get; set; }
        public double Price { get; set; }
        public bool IsReserved { get; set; }


        public Room()
        {
            _id++;
            id = _id;
        }

        public override string ToString()
        {
            return $"Otagin nomresi: {No}  Qiymeti: {Price}Azn    Rezerv olunub: {IsReserved}";
        }

    }
}
