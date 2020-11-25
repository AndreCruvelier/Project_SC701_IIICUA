

using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Solicitude : ICRUD<data.Solicitudes>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Solicitude(SolutionDBContext solutionDBContext) 
        {
            _solutionDBContext = solutionDBContext;        
        }
        public void Delete(data.Solicitudes t)
        {
            new Solution.DAL.Solicitude(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Solicitudes> GetAll()
        {
            return new Solution.DAL.Solicitude(_solutionDBContext).GetAll();
        }

        public data.Solicitudes GetOneById(int id)
        {
            return new Solution.DAL.Solicitude(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Solicitudes t)
        {
            //t.Id = null;
            new Solution.DAL.Solicitude(_solutionDBContext).Insert(t);
        }

        public void Update(data.Solicitudes t)
        {
            new Solution.DAL.Solicitude(_solutionDBContext).Update(t);
        }
    }
}
