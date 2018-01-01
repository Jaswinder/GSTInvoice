using ErrorLogger;
using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace DBManager
{
    public static class ConnectionModel
    {
        public static string ConnectionString;
        public static bool SetConnectionStrings()
        {
            try
            {
                GetConnectionParametersFromAppData();
                ConnectionString = ReadConnectionFromConfigFile();
                SqlConnection con = new SqlConnection(ConnectionString);

                con.Open();
                if (con.State.ToString() == "Open")
                {
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.Write(LOGTYPE.DBUPGRADE, "Error While Opening Database Connection: Method Name Is: SetConnectionStrings(): " + ex.Message + " Error line Number:" + ex.LineNumber());
                return false;
            }
        }
        private static bool DeleteAppConfigFromGleamBillDBFolder()
        {
            try
            {
                string destinationFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GleamBill DB";
                if (File.Exists(destinationFilePath + "\\app.config"))
                {
                    File.Delete(destinationFilePath + "\\app.config");
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.Write(LOGTYPE.DBUPGRADE, "Class Name:ConnectionModel.cs,Error While Deleting App config from ATAMDB folder Method Name: DeleteAppConfigFromATAMDBFolder():: " + ex.Message + " Error line Number:" + ex.LineNumber());
                return false;
            }
        }
        private static bool CheckConnectionAndUpdateXML(SqlConnectionStringBuilder builder, string connectionString)
        {
            bool isValid = false;
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
                using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                {
                    RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                    if (instanceKey != null)
                    {

                        foreach (var instanceName in instanceKey.GetValueNames())
                        {
                            string MachineName;
                            if (instanceName == "MSSQLSERVER")
                            {
                                MachineName = Environment.MachineName;
                            }
                            else
                            {
                                MachineName = Environment.MachineName + @"\" + instanceName;
                            }

                            builder.DataSource = MachineName;
                            builder.IntegratedSecurity = true;
                            connectionString = builder.ConnectionString;
                            con = new SqlConnection(connectionString);
                            try
                            {
                                con.Open();
                                if (con.State.ToString() == "Open")
                                {
                                    con.Close();
                                    UpdateConfigFile(connectionString);
                                    Log.Write(LOGTYPE.DBUPGRADE, "Connection successful with instance Name:" + builder.DataSource + " and database name:" + builder.InitialCatalog);
                                    return true;
                                }
                            }
                            catch (Exception ex2)
                            {
                                Log.Write(LOGTYPE.DBUPGRADE, "Not any error only intimation. Method Name: CheckConnectionAndUpdateXML: Connection not made with Instance name " + MachineName + " with database: " + builder.InitialCatalog + ". " + ex2.Message + " Error line Number:" + ex2.LineNumber());
                            }
                        }
                    }
                    else
                    {
                        DeleteAppConfigFromGleamBillDBFolder();
                        Log.Write(LOGTYPE.DBUPGRADE, "Class Name:ConnectionModel.cs,Method Name: CheckConnectionAndUpdateXML(): No instance find using RegistryKey,instanceKey is null");
                    }
                }
                return isValid;
            }
            catch (Exception ex)
            {
                DeleteAppConfigFromGleamBillDBFolder();
                Log.Write(LOGTYPE.DBUPGRADE, "Class Name:ConnectionModel.cs,Method Name: CheckConnectionAndUpdateXML " + ex.Message + " Error line Number:" + ex.LineNumber());
                return isValid;
            }
        }
        private static void UpdateConfigFile(string con)
        {
            try
            {
                //updating config file
                XmlDocument XmlDoc = new XmlDocument();
                //Loading the Config file
                XmlDoc.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GleamBill DB\\app.config");

                foreach (XmlElement xElement in XmlDoc.DocumentElement)
                {
                    if (xElement.Name == "connectionStrings")
                    {
                        //setting the connection string
                        xElement.FirstChild.Attributes[xElement.FirstChild.Attributes.Count - 1].Value = con;
                        break;
                    }
                }
                //writing the connection string in config file
                XmlDoc.Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GleamBill DB\\app.config");
            }
            catch (Exception ex)
            {
                Log.Write(LOGTYPE.DBUPGRADE, "Class Name:ConnectionModel.cs,Method Name: UpdateConfigFile() " + ex.Message + " Error line Number:" + ex.LineNumber());
            }
        }
        /// Will get the connection setting from app data folder ATAMDB and config file,Date 10 May 2016,Ticket#374
        private static bool GetConnectionParametersFromAppData()
        {
            try
            {
                string destinationFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GleamBill DB";
                if (!Directory.Exists(destinationFilePath))
                {
                    Directory.CreateDirectory(destinationFilePath);
                }

                if (!File.Exists(destinationFilePath + "\\app.config"))
                {
                    string Sourcefilepath = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
                    File.Copy(Sourcefilepath, destinationFilePath + "\\app.config", true);
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.Write(LOGTYPE.DBUPGRADE, "Class Name:ConnectionModel.cs,Error While copying config file from application installed to ATAMDB folder. Method Name: GetConnectionParametersFromAppData():: " + ex.Message + " Error line Number:" + ex.LineNumber());
                return false;
            }
        }
        /// In this method we will read conneciton string from the config file which is in xml format,Date 10 May 2016,Ticket#374
        private static string ReadConnectionFromConfigFile()
        {
            try
            {
                string connec = null;
                //updating config file
                XmlDocument XmlDoc = new XmlDocument();
                //Loading the Config file
                XmlDoc.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GleamBill DB\\app.config");

                foreach (XmlElement xElement in XmlDoc.DocumentElement)
                {
                    if (xElement.Name == "connectionStrings")
                    {
                        //setting the connection string
                        connec = xElement.FirstChild.Attributes[xElement.FirstChild.Attributes.Count - 1].Value;
                        break;
                    }
                }
                //writing the connection string in config file
                return connec;
            }
            catch (Exception ex)
            {
                Log.Write(LOGTYPE.DBUPGRADE, "Class Name:ConnectionModel.cs,Method Name: ReadConnectionFromConfigFile()" + ex.Message + " Error line Number:" + ex.LineNumber());
                return null;
            }
        }
    }
}

