

using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class TipoTrabajo : ICRUD<data.TipoTrabajo>
    {
        private SolutionDBContext _solutionDBContext = null;
        public TipoTrabajo(SolutionDBContext solutionDBContext) 
        {
            _solutionDBContext = solutionDBContext;        
        }
        public void Delete(data.TipoTrabajo t)
        {
            new Solution.DAL.TipoTrabajo(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.TipoTrabajo> GetAll()
        {
            return new Solution.DAL.TipoTrabajo(_solutionDBContext).GetAll();
        }

        public data.TipoTrabajo GetOneById(int id)
        {
            return new Solution.DAL.TipoTrabajo(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.TipoTrabajo t)
        {
            //t.Id = null;
            new Solution.DAL.TipoTrabajo(_solutionDBContext).Insert(t);
        }

        public void Update(data.TipoTrabajo t)
        {
            new Solution.DAL.TipoTrabajo(_solutionDBContext).Update(t);
        }
    }
}
