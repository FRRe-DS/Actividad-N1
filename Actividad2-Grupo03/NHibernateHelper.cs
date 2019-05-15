using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Text;


namespace Actividad2_Grupo03
{
    public static class NHibernateHelper
    {
        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MySQLConfiguration.Standard.ConnectionString("server=localhost;database=activ2_grupo03;user=root;password=1234"))
                                

                .Mappings(m =>

                    m.FluentMappings.AddFromAssemblyOf<Program>())

                        .ExposeConfiguration(cfg => new SchemaExport(cfg)

                                                        .Create(true, true))

                        .BuildSessionFactory();
        }
    }
}
