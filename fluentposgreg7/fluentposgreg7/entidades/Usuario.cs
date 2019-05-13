using System;
using System.Collections.Generic;
using System.Text;

namespace fluentposgreg7.entidades
{
    public class Usuario
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual char Status { get; set; }
    }
}
