using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace WMS___Projekt.DataAccess
{
    public static class SqlServerSearch
    {
        public static List<string> GetAvailableServers()
        {
            List<string> servers = new List<string>();
            
            try
            {
                // Try to get SQL Server instances from Windows Registry
                servers.AddRange(GetSqlServerInstancesFromRegistry());
                
                // Add common local instances
                var commonInstances = new List<string>
                {
                    "(local)",
                    "localhost",
                    ".\\SQLEXPRESS",
                    "(localdb)\\MSSQLLocalDB",
                    "127.0.0.1",
                    "."
                };
                
                foreach (var instance in commonInstances)
                {
                    if (!servers.Contains(instance))
                    {
                        servers.Add(instance);
                    }
                }
            }
            catch (Exception ex)
            {
                // If registry search fails, provide default instances
                Console.WriteLine($"SQL Server enumeration failed: {ex.Message}");
                
                servers.Add("(local)");
                servers.Add("localhost");
                servers.Add(".\\SQLEXPRESS");
                servers.Add("(localdb)\\MSSQLLocalDB");
                servers.Add("127.0.0.1");
                servers.Add(".");
            }
            
            return servers;
        }
        
        private static List<string> GetSqlServerInstancesFromRegistry()
        {
            List<string> instances = new List<string>();
            
            try
            {
                // Check for SQL Server instances in Windows Registry
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL"))
                {
                    if (key != null)
                    {
                        foreach (string instanceName in key.GetValueNames())
                        {
                            if (instanceName.Equals("MSSQLSERVER", StringComparison.OrdinalIgnoreCase))
                            {
                                // Default instance
                                instances.Add(Environment.MachineName);
                                instances.Add("(local)");
                                instances.Add("localhost");
                            }
                            else
                            {
                                // Named instance
                                instances.Add($"{Environment.MachineName}\\{instanceName}");
                                instances.Add($"(local)\\{instanceName}");
                                instances.Add($"localhost\\{instanceName}");
                            }
                        }
                    }
                }
                
                // Check for LocalDB instances
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions"))
                {
                    if (key != null)
                    {
                        foreach (string version in key.GetSubKeyNames())
                        {
                            instances.Add($"(localdb)\\{version}");
                        }
                    }
                }
                
                // Add common LocalDB instance
                instances.Add("(localdb)\\MSSQLLocalDB");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Registry search failed: {ex.Message}");
            }
            
            return instances;
        }
    }
}
