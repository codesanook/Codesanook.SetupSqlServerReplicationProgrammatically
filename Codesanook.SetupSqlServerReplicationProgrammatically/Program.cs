using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Replication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codesanook.SetupSqlServerReplicationProgrammatically
{
    class Program
    {
        static void Main(string[] args)
        {
            var sc = new ServerConnection("localhost");
            new PublicationMonitor();
            sc.Disconnect();
        }
    }
}
