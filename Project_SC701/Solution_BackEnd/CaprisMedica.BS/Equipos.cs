using CaprisMedica.DAL.EF;
using CaprisMedica.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = CaprisMedica.DO.Objects;

namespace CaprisMedica.BS
{
    public class Equipos : ICRUD<data.Equipos>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Equipos(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.Equipos t)
        {
            new CaprisMedica.DAL.Equipos(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Equipos> GetAll()
        {
            return new CaprisMedica.DAL.Equipos(_solutionDBContext).GetAll();
        }

        public data.Equipos GetOneById(int id)
        {
            return new CaprisMedica.DAL.Equipos(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Equipos t)
        {
            t.EquipoId = null;
            new CaprisMedica.DAL.Equipos(_solutionDBContext).Insert(t);
        }

        public void Update(data.Equipos t)
        {
            new CaprisMedica.DAL.Equipos(_solutionDBContext).Update(t);
        }
    }
}
