using System;
using System.Collections.Generic;
using System.Text;
using actividad2.Entity;
using actividad2.Services;

namespace actividad2.Services{
    public class PersonService
    {
        public  static void GetPerson(Person person)

        {

            Console.WriteLine(person.Name);

            Console.WriteLine();

        }
        

    }
}