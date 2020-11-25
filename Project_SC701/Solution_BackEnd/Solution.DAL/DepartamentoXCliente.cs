using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class Departamento_X_Cliente : ICRUD<data.Departamento_X_Cliente>
    {
        private Repository<data.Departamento_X_Cliente> _repository = null;
        public Departamento_X_Cliente(SolutionDBContext solutionDBContext) 
        {
            _repository = new Repository<data.Departamento_X_Cliente>(solutionDBContext);        
        }
        public void Delete(data.Departamento_X_Cliente t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Departamento_X_Cliente> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Departamento_X_Cliente GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.Departamento_X_Cliente t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.Departamento_X_Cliente t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
