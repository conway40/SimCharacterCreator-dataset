using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using SimCharacterCreator.Models;
using SimCharacterCreator.DataAccessLayer;
using Newtonsoft;
using Newtonsoft.Json;

namespace SimCharacterCreator.DataAccessLayer
{
    public class DataServiceJson : IDataService
    {
        private string _dataFilePath;


        /// <summary>
        /// read the json file and load a list of character objects
        /// </summary>
        /// <returns>list of characters</returns>
        public IEnumerable<Sim> ReadAll()
        {
            List<Sim> sims;

            try
            {
                using (StreamReader sr = new StreamReader(_dataFilePath))
                {
                    string jsonString = sr.ReadToEnd();

                    sims = JsonConvert.DeserializeObject<List<Sim>>(jsonString);

                }

            }
            catch (Exception)
            {
                throw;
            }

            return sims;
        }

        /// <summary>
        /// write the current list of characters to the json data file
        /// </summary>
        /// <param name="characters">list of characters</param>
        public void WriteAll(IEnumerable<Sim> sims)
        {
            string jsonString = JsonConvert.SerializeObject(sims);

            try
            {
                StreamWriter writer = new StreamWriter(_dataFilePath);
                using (writer)
                {
                    writer.WriteLine(jsonString);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataServiceJson()
        {
            _dataFilePath = DataConfig.DataPathJson;
        }
    }
}