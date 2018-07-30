using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace BCP_Application
{
    public class Location
    {
        public Location()
        {
            //Store a list of customers locations in memory
            locs = new List<string>();
         }

        private List<string> locs;
        public int LocId { get; set; }
        public String LocType { get; set; }
        public String LocName { get; set; }
        public String LocAddress { get; set; }

        public void AddLocation(string loc)
        {
            locs.Add(loc);
        }

        public string GetLocs()
        {
            String _locString = "------Start--------";

            GenLocList();

            int i = 0;

            foreach (string locs in locs)
            {
                _locString = _locString + locs;

                i = i + 1;
            }
            _locString = _locString + " -----END-----";
                
           return _locString;
        }

        public void GenLocList()

        {
           string strlistout ="";

            for (int i = 0; i < 5; i++)
                {
                strlistout = strlistout + i + "-Main-Store-123 Easy Way <CR>";
                AddLocation(strlistout);
                }              
             
        }


      }
}
