using LojaVirtual.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Infra.Repository
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {

        private LojaVirtualContext loja = new LojaVirtualContext();

        public void Adicionar(T entity)
        {
            loja.Set<T>().Add(entity);
            loja.SaveChanges();
        }

        public void Atualizar(T entity)
        {
            loja.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            loja.SaveChanges();
        }

        public T Buscar(object id)
        {
            return loja.Set<T>().Find(id);
        }

        public void Dispose()
        {
            loja.Dispose();
        }

        public List<T> ListarTodos()
        {
            return loja.Set<T>().ToList();
        }

        public void Remover(T entity)
        {
            loja.Set<T>().Remove(entity);
            loja.SaveChanges();
        }
    }
}
