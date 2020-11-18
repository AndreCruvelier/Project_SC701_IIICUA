using CaprisMedica.DAL.EF;
using CaprisMedica.DO.Interfaces;
using Solution.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using data = CaprisMedica.DO.Objects;

namespace CaprisMedica.DAL
{
    public class Equipos : ICRUD<data.Equipos>
    {
        private Repository<data.Equipos> _repository = null;
        public Equipos(SolutionDBContext solutionDBContext)
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
            _repository.Insert(t);
            _repository.Commit();
        }
    }
}
