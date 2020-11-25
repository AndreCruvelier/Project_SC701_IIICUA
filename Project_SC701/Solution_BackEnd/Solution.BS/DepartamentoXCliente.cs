

using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class DepartamentoXCliente : ICRUD<data.Departamento_X_Cliente>
    {
        private SolutionDBContext _solutionDBContext = null;
        public DepartamentoXCliente(SolutionDBContext solutionDBContext) 
        {
            _solutionDBContext = solutionDBContext;        
        }
        public void Delete(data.Departamento_X_Cliente t)
        {
            new Solution.DAL.Departamento_X_Cliente(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Departamento_X_Cliente> GetAll()
        {
            return new Solution.DAL.Departamento_X_Cliente(_solutionDBContext).GetAll();
        }

        public data.Departamento_X_Cliente GetOneById(int id)
        {
            return new Solution.DAL.Departamento_X_Cliente(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Departamento_X_Cliente t)
        {
            //t.Id = null;
            new Solution.DAL.Departamento_X_Cliente(_solutionDBContext).Insert(t);
        }

        public void Update(data.Departamento_X_Cliente t)
        {
            new Solution.DAL.Departamento_X_Cliente(_solutionDBContext).Update(t);
        }
    }
}
