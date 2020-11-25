using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class Provincias : ICRUD<data.Provincias>
    {
        private Repository<data.Provincias> _repository = null;
        public Provincias(SolutionDBContext solutionDBContext) 
        {
            _repository = new Repository<data.Provincias>(solutionDBContext);        
        }
        public void Delete(data.Provincias t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Provincias> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Provincias GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.Provincias t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.Provincias t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
