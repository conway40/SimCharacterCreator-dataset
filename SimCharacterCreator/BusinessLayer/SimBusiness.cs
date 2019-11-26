using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCharacterCreator.Models;
using SimCharacterCreator.DataAccessLayer;

namespace SimCharacterCreator.BusinessLayer
{
    public enum FileIoMessage
    {
        None,
        Complete,
        FileAccessError,
        RecordNotFound
    }

    public class SimBusiness
    {
        public FileIoMessage FileIoStatus { get; set; }

        public SimBusiness()
        {

        }

        /// <summary>
        /// retrieve a list of all characters
        /// </summary>
        /// <returns>all characters</returns>
        private List<Sim> SimsList()
        {
            List<Sim> sims = new List<Sim>();
            FileIoStatus = FileIoMessage.None;

            using (SimRepository simRepository = new SimRepository())
            {
                try
                {
                    sims = simRepository.GetAll() as List<Sim>;
                    FileIoStatus = FileIoMessage.Complete;
                }
                catch (Exception)
                {
                    FileIoStatus = FileIoMessage.FileAccessError;
                }
            };

            return sims;
        }

        /// <summary>
        /// retrieve a list of all characters
        /// </summary>
        /// <returns>list of all characters</returns>
        public List<Sim> AllSims()
        {
            return SimsList() as List<Sim>;
        }

        /// <summary>
        /// retrieve a character by id
        /// </summary>
        /// <param name="id">character id</param>
        /// <returns>character</returns>
        public Sim SimById(int id)
        {
            List<Sim> sims = SimsList();
            Sim sim = sims.FirstOrDefault(c => c.Id == id);

            if (sim == null)
            {
                FileIoStatus = FileIoMessage.RecordNotFound;
            }
            else
            {
                FileIoStatus = FileIoMessage.Complete;
            }

            return sim;
        }

        /// <summary>
        /// Add a character
        /// </summary>
        /// <param name="character"></param>
        public void AddSim(Sim sim)
        {
            FileIoStatus = FileIoMessage.None;

            using (SimRepository simRepository = new SimRepository())
            {
                try
                {
                    simRepository.Add(sim);
                    FileIoStatus = FileIoMessage.Complete;
                }
                catch (Exception)
                {
                    FileIoStatus = FileIoMessage.FileAccessError;
                }
            }
        }
        /// <summary>
        /// Delete a character
        /// </summary>
        /// <param name="character"></param>
        public void DeleteSim(Sim sim)
        {
            FileIoStatus = FileIoMessage.None;

            using (SimRepository simRepository = new SimRepository())
            {
                try
                {
                    simRepository.Delete(sim.Id);
                    FileIoStatus = FileIoMessage.Complete;
                }
                catch (Exception)
                {
                    FileIoStatus = FileIoMessage.FileAccessError;
                }
            }
        }
    }
}
