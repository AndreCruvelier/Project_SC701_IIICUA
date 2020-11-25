

using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Empleado : ICRUD<data.Empleados>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Empleado(SolutionDBContext solutionDBContext) 
        {
            _solutionDBContext = solutionDBContext;        
        }
        public void Delete(data.Empleados t)
        {
            new Solution.DAL.Empleado(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Empleados> GetAll()
        {
            return new Solution.DAL.Empleado(_solutionDBContext).GetAll();
        }

        public data.Empleados GetOneById(int id)
        {
            return new Solution.DAL.Empleado(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Empleados t)
        {
            //t.Id = null;
            new Solution.DAL.Empleado(_solutionDBContext).Insert(t);
        }

        public void Update(data.Empleados t)
        {
            new Solution.DAL.Empleado(_solutionDBContext).Update(t);
        }
    }
}
