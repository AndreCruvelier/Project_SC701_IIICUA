using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class TipoCedula : ICRUD<data.TipoCedula>
    {
        private Repository<data.TipoCedula> _repository = null;
        public TipoCedula(SolutionDBContext solutionDBContext) 
        {
            _repository = new Repository<data.TipoCedula>(solutionDBContext);        
        }
        public void Delete(data.TipoCedula t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.TipoCedula> GetAll()
        {
            return _repository.GetAll();
        }

        public data.TipoCedula GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.TipoCedula t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.TipoCedula t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
