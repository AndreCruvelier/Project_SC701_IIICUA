

using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Equipo : ICRUD<data.Equipos>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Equipo(SolutionDBContext solutionDBContext) 
        {
            _solutionDBContext = solutionDBContext;        
        }
        public void Delete(data.Equipos t)
        {
            new Solution.DAL.Equipo(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Equipos> GetAll()
        {
            return new Solution.DAL.Equipo(_solutionDBContext).GetAll();
        }

        public data.Equipos GetOneById(int id)
        {
            return new Solution.DAL.Equipo(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Equipos t)
        {
            //t.Id = null;
            new Solution.DAL.Equipo(_solutionDBContext).Insert(t);
        }

        public void Update(data.Equipos t)
        {
            new Solution.DAL.Equipo(_solutionDBContext).Update(t);
        }
    }
}
