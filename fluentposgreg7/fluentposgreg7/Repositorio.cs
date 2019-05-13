using NHibernate;
using System;
using System.Collections.Generic;
using NHibernate.Linq;
using System.Linq;

namespace fluentposgreg7
{
   public class Repositorio<T> : IUsuarioCrud<T> where T : class
    {
        public void Inserir(T entidade)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao inserir Cliente : " + ex.Message);
                    }
                }
            }
        }
        public void Alterar(T entidade)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao Alterar Cliente : " + ex.Message);
                    }
                }
            }
        }
        public void Excluir(T entidade)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao Excluir Cliente : " + ex.Message);
                    }
                }
            }
        }
        public T RetornarPorId(int Id)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return session.Get<T>(Id);
            }
        }
        public IList<T> Consultar()
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from c in session.Query<T>() select c).ToList();
            }
        }
    }
}
