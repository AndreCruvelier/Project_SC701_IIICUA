

using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Provincias : ICRUD<data.Provincias>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Provincias(SolutionDBContext solutionDBContext) 
        {
            _solutionDBContext = solutionDBContext;        
        }
        public void Delete(data.Provincias t)
        {
            new Solution.DAL.Provincias(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Provincias> GetAll()
        {
            return new Solution.DAL.Provincias(_solutionDBContext).GetAll();
        }

        public data.Provincias GetOneById(int id)
        {
            return new Solution.DAL.Provincias(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Provincias t)
        {
            //t.Id = null;
            new Solution.DAL.Provincias(_solutionDBContext).Insert(t);
        }

        public void Update(data.Provincias t)
        {
            new Solution.DAL.Provincias(_solutionDBContext).Update(t);
        }
    }
}
