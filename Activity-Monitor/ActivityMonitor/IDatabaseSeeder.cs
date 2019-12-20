using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor
{
    interface IDatabaseSeeder
    {
        System.Threading.Tasks.Task Seed();
    }
}
