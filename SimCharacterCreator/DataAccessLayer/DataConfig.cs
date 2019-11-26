using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimCharacterCreator.Models;

namespace SimCharacterCreator.DataAccessLayer
{
    public class DataConfig
    {
        //
        // set the type of persistence
        //
        //public static DataType dataType = DataType.XML;
        public static SeedDataType dataType = SeedDataType.JSON;

        public static string DataPathJson => @"DataAccessLayer\simdata.json";
        //public static string DataPathXml => @"DataAccessLayer\.xml";
    }
}