using System.Collections.Generic;
using System.Linq;
using Pizzaria.Model.Data;
using System.Data.Entity;
using Mike.Utilities.Desktop;
using System;
namespace Pizzaria.Controller.Repository
{
    public class DefaultRepositorio<T> where T : class
    {
        private _DbContext banco;
        protected DbSet<T> entities { private set; get; }
        protected DefaultRepositorio()
        {
            entities = (banco = new _DbContext()).Set<T>();
        }
        public virtual List<T> Listar()
        {
            try
            {
                return entities.ToList();
            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
        public virtual T GetPeloID(int? id)
        {
            try
            {
                return entities.Find(id);
            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
        public virtual bool Salvar(T entities)
        {
            try
            {
                this.entities.Add(entities);
                return Confirmar();
            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
        public virtual bool Editar(T entities)
        {
            try
            {
                banco.Entry<T>(entities).State = EntityState.Modified;
                return Confirmar();
            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
        public virtual bool Deletar(int? id)
        {
            try
            {
                var TEntity = this.GetPeloID(id);
                entities.Remove(TEntity);
                return Confirmar();
            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
        public virtual int GetQuantidade()
        {
            try
            {
                return entities.Count();
            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
        protected bool Confirmar()
                => (banco.SaveChanges() > 0);
      

    }
}
