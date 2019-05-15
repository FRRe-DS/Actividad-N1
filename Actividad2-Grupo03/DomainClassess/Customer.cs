using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad2_Grupo03.DomainClassess
{
    public class Customer
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }

    }
}
