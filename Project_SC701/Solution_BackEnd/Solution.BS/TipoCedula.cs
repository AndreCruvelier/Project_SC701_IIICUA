

using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class TipoCedula : ICRUD<data.TipoCedula>
    {
        private SolutionDBContext _solutionDBContext = null;
        public TipoCedula(SolutionDBContext solutionDBContext) 
        {
            _solutionDBContext = solutionDBContext;        
        }
        public void Delete(data.TipoCedula t)
        {
            new Solution.DAL.TipoCedula(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.TipoCedula> GetAll()
        {
            return new Solution.DAL.TipoCedula(_solutionDBContext).GetAll();
        }

        public data.TipoCedula GetOneById(int id)
        {
            return new Solution.DAL.TipoCedula(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.TipoCedula t)
        {
            //t.Id = null;
            new Solution.DAL.TipoCedula(_solutionDBContext).Insert(t);
        }

        public void Update(data.TipoCedula t)
        {
            new Solution.DAL.TipoCedula(_solutionDBContext).Update(t);
        }
    }
}
