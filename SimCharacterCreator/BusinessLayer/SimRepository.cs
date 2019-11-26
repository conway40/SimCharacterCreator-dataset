using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCharacterCreator.Models;
using SimCharacterCreator.DataAccessLayer;

namespace SimCharacterCreator.BusinessLayer
{
    /// <summary>
    /// Repository for CRUD
    /// Note: the _dataService object is instantiated with either the XML or Json class based on the value set in the DataConfig class
    /// </summary>
    class SimRepository : ISimRepository, IDisposable
    {
        private IDataService _dataService;
        List<Sim> _sims;

        /// <summary>
        /// set the correct data service (XML or Json) data service and read in a list of all characters
        /// </summary>
        public SimRepository()
        {
            _dataService = SetDataService();
            _sims = _dataService.ReadAll() as List<Sim>;
        }

        /// <summary>
        /// instantiate and return the correct data service (XML or Json) 
        /// </summary>
        /// <returns>data service object</returns>
        private IDataService SetDataService()
        {
            switch (DataConfig.dataType)
            {
                //case DataType.XML:
                    //return new DataServiceXml();
                    //break;

                case SeedDataType.JSON:
                    return new DataServiceJson();
                    break;

                default:
                    throw new Exception();
                    break;
            }
        }

        /// <summary>
        /// add a new character
        /// </summary>
        /// <param name="character">caracter</param>
        public void Add(Sim sim)
        {
            _sims.Add(sim);
            _dataService.WriteAll(_sims);
        }

        /// <summary>
        /// delete a character
        /// </summary>
        /// <param name="id">character id</param>
        public void Delete(int id)
        {
            _sims.Remove(_sims.FirstOrDefault(c => c.Id == id));
            _dataService.WriteAll(_sims);
        }

        /// <summary>
        /// retrieve all characters
        /// </summary>
        /// <returns>all characters</returns>
        public IEnumerable<Sim> GetAll()
        {
            return _sims;
        }

        /// <summary>
        /// retrieve a character by the id
        /// </summary>
        /// <param name="id">character id</param>
        /// <returns></returns>
        public Sim GetById(int id)
        {
            return _sims.FirstOrDefault(c => c.Id == id);
        }

        /// <summary>
        /// update a character
        /// </summary>
        /// <param name="character">character</param>
        public void Update(Sim sim)
        {
            _sims.Remove(_sims.FirstOrDefault(c => c.Id == sim.Id));
            _sims.Add(sim);
        }

        /// <summary>
        /// required if class will be use in a 'using" block
        /// </summary>
        public void Dispose()
        {
            _dataService = null;
            _sims = null;
        }
    }
}
