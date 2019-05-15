using System;
using actividad2.Entity;
using actividad2.Services;
using actividad2.SessionFactories;

namespace actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create our NHibernate session factory
            string connectionStringName = "Server=localhost;Port=3306;Database=turnos;Uid=root;Pwd=111111;";
            var sessionFactory = SessionFactoryBuilder.BuildSessionFactory(connectionStringName, true, true);


            using (var session = sessionFactory.OpenSession())

            {

                // populate the database

                using (var transaction = session.BeginTransaction())


                {

                    // create a couple of Persons

                    var person1 = new Person { Name = "Rayen Trabelsi" };

                    var person2 = new Person { Name = "Mohamed Trabelsi" };

                    var person3 = new Person { Name = "Hamida Rebai" };


                    //create tasks



                    var task1 = new Task {Title = "Task 1", State = TaskState.Open, AssignedTo = person1};
                    var task2 = new Task { Title = "Task 2", State = TaskState.Closed, AssignedTo = person2 };
                    var task3 = new Task { Title = "Task 3", State = TaskState.Closed, AssignedTo = person3 };


                    // save both stores, this saves everything else via cascading

                    session.SaveOrUpdate(task1);

                    session.SaveOrUpdate(task2);

                    session.SaveOrUpdate(task3);


                    transaction.Commit();

                }





                using (var session2 = sessionFactory.OpenSession())

                {

                    //retreive all tasks with person assigned to

                    using (session2.BeginTransaction())

                    {

                        var tasks = session.CreateCriteria(typeof(Task))

                            .List<Task>();



                        foreach (var task in tasks)

                        {

                            TaskService.GetTaskInfo(task);

                        }

                    }

                }


                Console.ReadKey();

            }


        }
    }
}