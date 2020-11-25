using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class Solicitude : ICRUD<data.Solicitudes>
    {
        private Repository<data.Solicitudes> _repository = null;
        public Solicitude(SolutionDBContext solutionDBContext) 
        {
            _repository = new Repository<data.Solicitudes>(solutionDBContext);        
        }
        public void Delete(data.Solicitudes t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Solicitudes> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Solicitudes GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.Solicitudes t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.Solicitudes t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
