using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class TipoTrabajo : ICRUD<data.TipoTrabajo>
    {
        private Repository<data.TipoTrabajo> _repository = null;
        public TipoTrabajo(SolutionDBContext solutionDBContext) 
        {
            _repository = new Repository<data.TipoTrabajo>(solutionDBContext);        
        }
        public void Delete(data.TipoTrabajo t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.TipoTrabajo> GetAll()
        {
            return _repository.GetAll();
        }

        public data.TipoTrabajo GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.TipoTrabajo t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.TipoTrabajo t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
