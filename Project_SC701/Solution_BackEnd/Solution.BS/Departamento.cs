

using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Departamento : ICRUD<data.Departamentos>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Departamento(SolutionDBContext solutionDBContext) 
        {
            _solutionDBContext = solutionDBContext;        
        }
        public void Delete(data.Departamentos t)
        {
            new Solution.DAL.Departamento(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Departamentos> GetAll()
        {
            return new Solution.DAL.Departamento(_solutionDBContext).GetAll();
        }

        public data.Departamentos GetOneById(int id)
        {
            return new Solution.DAL.Departamento(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Departamentos t)
        {
            //t.Id = null;
            new Solution.DAL.Departamento(_solutionDBContext).Insert(t);
        }

        public void Update(data.Departamentos t)
        {
            new Solution.DAL.Departamento(_solutionDBContext).Update(t);
        }
    }
}
