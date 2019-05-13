using System.Linq;
using NHibernate;
using NHibernate.Linq;
using fluentposgreg7.entidades;


namespace fluentposgreg7.mapeo
{
   public class UsuarioRepositorio: Repositorio<Usuario>
    {
        public bool ValidarLogin(string login)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<Usuario>() where e.Login.Equals(login) select e).Count() > 0;
            }
        }
        public bool ValidarAcesso(string login, string senha)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<Usuario>() where e.Login.Equals(login) && e.Senha.Equals(senha) select e).Count() > 0;
            }
        }
    }
}
