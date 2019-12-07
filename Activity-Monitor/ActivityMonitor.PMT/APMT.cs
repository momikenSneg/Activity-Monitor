using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ActivityMonitor.PMT
{
    /// <summary>
    /// Common interface for project managment tools
    /// </summary>
    public interface APMT
    {
        string[] GetProjects();
        Task<string[]> GetUsers(string project);
    }
}
