using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitalizeConnections(bool database, bool textFiles)
        {
            Connections = new List<IDataConnection>();
            if (database)
            {
                //TO DO - Create the SQL Connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                //TO DO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
