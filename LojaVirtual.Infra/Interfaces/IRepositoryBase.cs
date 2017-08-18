using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Infra.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {

        void Adicionar(T entity);

        void Remover(T entity);

        void Atualizar(T entity);

        List<T> ListarTodos();

        T Buscar(object id);

    }
}
