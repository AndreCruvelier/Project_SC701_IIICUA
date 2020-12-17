using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using Solution.DO.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class Empleado : ICRUD<data.Empleados>
    {
        private Repository<data.Empleados> _repository = null;
        public Empleado(SolutionDBContext solutionDBContext) 
        {
            _repository = new Repository<data.Empleados>(solutionDBContext);        
        }
        public void Delete(data.Empleados t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Empleados> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Empleados GetOneById(string id)
        {
            return _repository.GetOneById(id);
        }

        public Empleados GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Empleados t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.Empleados t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
