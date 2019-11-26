using SimCharacterCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCharacterCreator.DataAccessLayer
{
    public interface IDataService
    {
        IEnumerable<Sim> ReadAll();
        void WriteAll(IEnumerable<Sim> sims);
    }
}
