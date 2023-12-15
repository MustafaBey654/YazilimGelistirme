using ConsoleApp1.Deneme.abstracts;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Deneme
{
    public class PersonManager
    {
       public void Add(IPerson person)
        {
            Console.WriteLine(person.Name);
        }
    }
}
