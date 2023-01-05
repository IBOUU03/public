using ConsoleApp9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Service.Interface
{
    internal interface IServices
    {
        public void Create(int no, double price);
        public Room[] GetAll();
        public void Reserve(int id);
    }
}
