

using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Role : ICRUD<data.Roles>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Role(SolutionDBContext solutionDBContext) 
        {
            _solutionDBContext = solutionDBContext;        
        }
        public void Delete(data.Roles t)
        {
            new Solution.DAL.Role(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Roles> GetAll()
        {
            return new Solution.DAL.Role(_solutionDBContext).GetAll();
        }

        public data.Roles GetOneById(int id)
        {
            return new Solution.DAL.Role(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Roles t)
        {
            //t.Id = null;
            new Solution.DAL.Role(_solutionDBContext).Insert(t);
        }

        public void Update(data.Roles t)
        {
            new Solution.DAL.Role(_solutionDBContext).Update(t);
        }
    }
}
