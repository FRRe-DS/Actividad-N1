using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Configuration = NHibernate.Cfg.Configuration;
using MySql.Data.MySqlClient;
using FluentNHibernate.Cfg.Db;

namespace actividad2.SessionFactories
{

    public class SessionFactoryBuilder
 {
   
 
 //var listOfEntityMap = typeof(M).Assembly.GetTypes().Where
 //(t => t.GetInterfaces().Contains(typeof(M))).ToList();
 //var sessionFactory = SessionFactoryBuilder.BuildSessionFactory
 //(dbmsTypeAsString, connectionStringName, listOfEntityMap, withLog, create, update); 
 
  public static ISessionFactory BuildSessionFactory
   (string connectionStringName, bool create = false, bool update = false)
 {
 return Fluently.Configure()
 .Database(MySQLConfiguration.Standard.ConnectionString(x => x.Database("turnos")
 .Server("localhost")
 .Username("root")
 .Password("111111")/* ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString)*/))
 //.Mappings(m => entityMappingTypes.ForEach(e => { m.FluentMappings.Add(e); }))
 .Mappings(m =>m.FluentMappings.AddFromAssemblyOf<NHibernate.Cfg.Mappings>())
 .CurrentSessionContext("call")
 .ExposeConfiguration(cfg => BuildSchema(cfg, create, update))
 .BuildSessionFactory();
 }
 
 /// <summary>
 /// Build the schema of the database.
 /// </summary>
 /// <param name="config">Configuration.</param>
 private static void BuildSchema(Configuration config, bool create = false, bool update = false)
 {
 if (create)
 {
 new SchemaExport(config).Create(false, true);
 }
 else
 {
 new SchemaUpdate(config).Execute(false, update);
 }
 }
}
}