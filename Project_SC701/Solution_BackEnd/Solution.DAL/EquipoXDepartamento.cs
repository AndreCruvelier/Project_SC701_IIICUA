using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class Equipo_X_Departamento : ICRUD<data.Equipo_X_Departamento>
    {
        private Repository<data.Equipo_X_Departamento> _repository = null;
        public Equipo_X_Departamento(SolutionDBContext solutionDBContext) 
        {
            _repository = new Repository<data.Equipo_X_Departamento>(solutionDBContext);        
        }
        public void Delete(data.Equipo_X_Departamento t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Equipo_X_Departamento> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Equipo_X_Departamento GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.Equipo_X_Departamento t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.Equipo_X_Departamento t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
