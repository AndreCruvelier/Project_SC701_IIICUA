using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class Cliente : ICRUD<data.Clientes>
    {
        private Repository<data.Clientes> _repository = null;
        public Cliente(SolutionDBContext solutionDBContext) 
        {
            _repository = new Repository<data.Clientes>(solutionDBContext);        
        }
        public void Delete(data.Clientes t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Clientes> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Clientes GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.Clientes t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.Clientes t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
