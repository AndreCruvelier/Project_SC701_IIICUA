using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class Departamento : ICRUD<data.Departamentos>
    {
        private Repository<data.Departamentos> _repository = null;
        public Departamento(SolutionDBContext solutionDBContext) 
        {
            _repository = new Repository<data.Departamentos>(solutionDBContext);        
        }
        public void Delete(data.Departamentos t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Departamentos> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Departamentos GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.Departamentos t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.Departamentos t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
