using ActivityMonitor.Database;
using ActivityMonitor.PMT;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor
{
    class PMTDatabaseSeeder : IDatabaseSeeder
    {
        private ActivityContext context;
        private List<string> prj;
        private APMT pmt;
        public PMTDatabaseSeeder(ActivityContext c, List<string> projects, string name, string password, string url)
        {
            context = c;
            prj = projects;
            pmt = new PMT.PMT(name, password, new Uri(url));
        }
        public void Seed()
        {
            throw new NotImplementedException();
        }
    }
}
