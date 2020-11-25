

using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Cliente : ICRUD<data.Clientes>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Cliente(SolutionDBContext solutionDBContext) 
        {
            _solutionDBContext = solutionDBContext;        
        }
        public void Delete(data.Clientes t)
        {
            new Solution.DAL.Cliente(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Clientes> GetAll()
        {
            return new Solution.DAL.Cliente(_solutionDBContext).GetAll();
        }

        public data.Clientes GetOneById(int id)
        {
            return new Solution.DAL.Cliente(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Clientes t)
        {
            //t.Id = null;
            new Solution.DAL.Cliente(_solutionDBContext).Insert(t);
        }

        public void Update(data.Clientes t)
        {
            new Solution.DAL.Cliente(_solutionDBContext).Update(t);
        }
    }
}
