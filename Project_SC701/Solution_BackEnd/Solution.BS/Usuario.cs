

using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Usuario : ICRUD<data.Usuarios>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Usuario(SolutionDBContext solutionDBContext) 
        {
            _solutionDBContext = solutionDBContext;        
        }
        public void Delete(data.Usuarios t)
        {
            new Solution.DAL.Usuario(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Usuarios> GetAll()
        {
            return new Solution.DAL.Usuario(_solutionDBContext).GetAll();
        }

        public data.Usuarios GetOneById(int id)
        {
            return new Solution.DAL.Usuario(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Usuarios t)
        {
            //t.Id = null;
            new Solution.DAL.Usuario(_solutionDBContext).Insert(t);
        }

        public void Update(data.Usuarios t)
        {
            new Solution.DAL.Usuario(_solutionDBContext).Update(t);
        }
    }
}
