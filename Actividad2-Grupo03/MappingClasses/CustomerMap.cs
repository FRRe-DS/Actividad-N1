using System;
using System.Collections.Generic;
using System.Text;
using Actividad2_Grupo03.DomainClassess;
using FluentNHibernate.Mapping;

namespace Actividad2_Grupo03.MappingClasses
{
    public class CustomerMap : ClassMap<Customer>
    { 
        public CustomerMap()
        {
            Id(c => c.Id);
            Map(c => c.FirstName).Not.Nullable();
            Map(c => c.MiddleName);
            Map(c => c.LastName).Not.Nullable();
        }

    }
}
