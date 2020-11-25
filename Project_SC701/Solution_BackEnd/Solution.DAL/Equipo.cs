using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class Equipo : ICRUD<data.Equipos>
    {
        private Repository<data.Equipos> _repository = null;
        public Equipo(SolutionDBContext solutionDBContext) 
        {
            _repository = new Repository<data.Equipos>(solutionDBContext);        
        }
        public void Delete(data.Equipos t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Equipos> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Equipos GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.Equipos t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.Equipos t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
