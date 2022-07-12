﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection> ();

        public static void InitilizeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Create the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create the text collection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}