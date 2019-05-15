using System;

namespace Actividad2_Grupo03
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var isession = NHibernateHelper.CreateSessionFactory())
            {
            }
            Console.ReadLine();
        }
    }
}
