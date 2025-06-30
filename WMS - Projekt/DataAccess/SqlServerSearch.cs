using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;

namespace WMS___Projekt.DataAccess
{
    public static class SqlServerSearch
    {
        public static List<string> GetAvailableServers()
        {
            List<string> servers = new List<string>();
            try
            {
                DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
                foreach (DataRow row in dt.Rows)
                {
                    string server = row["ServerName"].ToString();
                    string instance = row["InstanceName"].ToString();
                    if (!string.IsNullOrEmpty(instance))
                    {
                        servers.Add($"{server}\\{instance}");
                    }
                    else
                    {
                        servers.Add(server);
                    }
                }
            }
            catch
            {
                // Enumeration can fail depending on environment.
            }
            return servers;
        }
    }
}
