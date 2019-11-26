using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCharacterCreator.Models;

namespace SimCharacterCreator.BusinessLayer
{
    public interface ISimRepository
    {
        IEnumerable<Sim> GetAll();
        Sim GetById(int id);
        void Add(Sim sim);
        void Update(Sim sim);
        void Delete(int id);
    }
}
