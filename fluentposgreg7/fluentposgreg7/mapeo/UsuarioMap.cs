using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FluentNHibernate.Mapping;
using fluentposgreg7.entidades;

namespace fluentposgreg7.mapeo
{
    class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
            {
               Id(c => c.Id);
               Map(c => c.Nome);
               Map(c => c.Login);
               Map(c => c.Senha);
               Map(c => c.Status);
               Table("usuario");
             }
     
    }
}
