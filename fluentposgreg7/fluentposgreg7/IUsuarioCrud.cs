using System;
using System.Collections.Generic;
using System.Text;

namespace fluentposgreg7
{
   public interface IUsuarioCrud<T>
    {
        void Inserir(T entidade);
        void Alterar(T entidade);
        void Excluir(T entidade);
        T RetornarPorId(int Id);
        IList<T> Consultar();
    }
}
