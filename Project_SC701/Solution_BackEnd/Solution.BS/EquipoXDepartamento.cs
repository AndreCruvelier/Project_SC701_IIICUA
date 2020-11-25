

using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Equipo_X_Departamento : ICRUD<data.Equipo_X_Departamento>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Equipo_X_Departamento(SolutionDBContext solutionDBContext) 
        {
            _solutionDBContext = solutionDBContext;        
        }
        public void Delete(data.Equipo_X_Departamento t)
        {
            new Solution.DAL.Equipo_X_Departamento(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Equipo_X_Departamento> GetAll()
        {
            return new Solution.DAL.Equipo_X_Departamento(_solutionDBContext).GetAll();
        }

        public data.Equipo_X_Departamento GetOneById(int id)
        {
            return new Solution.DAL.Equipo_X_Departamento(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Equipo_X_Departamento t)
        {
            //t.Id = null;
            new Solution.DAL.Equipo_X_Departamento(_solutionDBContext).Insert(t);
        }

        public void Update(data.Equipo_X_Departamento t)
        {
            new Solution.DAL.Equipo_X_Departamento(_solutionDBContext).Update(t);
        }
    }
}
