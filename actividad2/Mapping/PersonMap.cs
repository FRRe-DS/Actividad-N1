using FluentNHibernate.Mapping;
using actividad2.Mapping;
using actividad2.Entity;

namespace actividad2.Mapping{
public class PersonMap : ClassMap<Person>
{
public PersonMap()
{
Id(x => x.Id);

Map(x => x.Name);

Map(x => x.CreationDate);
Map(x => x.UpdatedDate);
}
}
}