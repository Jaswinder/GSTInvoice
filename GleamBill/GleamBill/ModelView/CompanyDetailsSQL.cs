using GleamBill.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using ErrorLogger;
using DBManager;

namespace GleamBill.ModelView
{

    public static class CompanyDetailsSQL
    {
        public static string GetDefaultConection()
        {
            return File.Exists(Path.Combine(Directory.GetCurrentDirectory(), @"Userdata\gleambill.db")) ?
              Path.Combine(Directory.GetCurrentDirectory(), @"Userdata\gleambill.db")
            : string.Empty;

        }

        public static void SetUpDatabase()
        {
            string path = @"Userdata/gleambill.db";
            //if(System.IO.File.Exists(path)) I forgot to use the full path
            if (System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), path)))
            {

            }
        }
        public static List<GenericListBinder> GetAllCountries()
        {
            List<GenericListBinder> list = new List<GenericListBinder>();
            SqlConnection con = null;
            using (con = new SqlConnection(ConnectionModel.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetCountry", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader rd = null;
                    try
                    {
                        rd = cmd.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        Log.Write(LOGTYPE.GLEAMBILLERROR, "CompanyDetailsSQL.cs GetStatesInCountry() - " + ex.Message);
                    }
                    while (rd.Read())
                    {
                        list.Add(new GenericListBinder()
                        {
                            ID = rd.GetInt32("ID"),
                            Name = rd.GetString("Name")
                        });
                    }
                }
            }
            return list;
        }

        public static List<string> GetAllCurrencies()
        {
            //SQLiteConnection con = new SQLiteConnection("Data Source =" + GetDefaultConection() + ";");
            //SQLiteCommand sqlcmd = new SQLiteCommand();
            //SQLiteDataAdapter sqladp = new SQLiteDataAdapter();
            //DataSet ds = new DataSet();
            //sqlcmd.Connection = con;
            //sqlcmd.CommandType = CommandType.Text;
            //sqlcmd.CommandText = "Select currency_symbol,id from currencies";
            //sqladp.SelectCommand = sqlcmd;
            //sqladp.Fill(ds, "currencies");

            //List<string> currencylist = ds.Tables["currencies"].AsEnumerable()
            //               .Select(r => r.Field<string>("currency_symbol"))
            //               .ToList();
            //if (currencylist.Count > 0)
            //    currencylist.Insert(0, "Select a currency");
            //return currencylist;

            string ConnectionString = ConnectionModel.ConnectionString;
            List<string> list = new List<string>();
            SqlConnection con = null;
            SqlDataReader rd = null;

            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("getCurrency", con);
                cmd.CommandType = CommandType.StoredProcedure;

                rd = cmd.ExecuteReader();


                while (rd.Read())
                {
                    var myString = rd["CurrencyName"].ToString();
                    list.Add(myString);
                }
            }
            finally
            {
                if (con != null) { con.Close(); }
                if (rd != null) { rd.Close(); }
            }
            return list;
        }

        public static List<GenericListBinder> GetStatesInCountry(int countryID)
        {
            List<GenericListBinder> list = new List<GenericListBinder>();
            SqlConnection con = null;
            using (con = new SqlConnection(ConnectionModel.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetStatesByCountryID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@countryID", SqlDbType.Int).Value = countryID;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        list.Add(new GenericListBinder()
                        {
                            ID = rd.GetInt32FromString("Code"),
                            Name = rd.GetString("Name")
                        });
                    }
                }
            }
            return list;
        }
        public static void InsertUpdateCompanyDetail(CompanyDetail objCompanyDetail)
        {
            SqlConnection con = null;
            using (con = new SqlConnection(ConnectionModel.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("InsertUpdateCompanyDetail", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@CompanyID ", SqlDbType.UniqueIdentifier).Value = objCompanyDetail.CompanyID;
                    cmd.Parameters.Add("@CompanyName ", SqlDbType.NVarChar).Value = objCompanyDetail.CompanyName;

                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = objCompanyDetail.Address;
                    cmd.Parameters.Add("@PINCode", SqlDbType.NVarChar).Value = objCompanyDetail.PINCode;
                    cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = objCompanyDetail.City;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = objCompanyDetail.CompanyEmail;
                    //cmd.Parameters.Add("@Telephone", SqlDbType.Int).Value = objCompanyDetail.CompanyPhone;
                    cmd.Parameters.Add("@WebsiteLogo", SqlDbType.NVarChar).Value = objCompanyDetail.WebsiteLogo;
                    cmd.Parameters.Add("@Website", SqlDbType.NVarChar).Value = objCompanyDetail.CompanyWebsite;
                    cmd.Parameters.Add("@Details", SqlDbType.NVarChar).Value = objCompanyDetail.AdditionalDetails;
                    cmd.Parameters.Add("@StateID", SqlDbType.Int).Value = objCompanyDetail.StateID;
                    cmd.Parameters.Add("@CurrencyID", SqlDbType.Int).Value = objCompanyDetail.CurrencyID;
                    cmd.Parameters.Add("@TIN_VAT", SqlDbType.NVarChar).Value = objCompanyDetail.TINVAT;
                    cmd.Parameters.Add("@PAN", SqlDbType.NVarChar).Value = objCompanyDetail.PAN;
                    cmd.Parameters.Add("@GSTIN", SqlDbType.NVarChar).Value = objCompanyDetail.GSTIN;
                    cmd.Parameters.Add("@ServiceCategoryID", SqlDbType.Int).Value = objCompanyDetail.ServiceCategoryID;
                    cmd.Parameters.Add("@ServiceTaxCSTTINNo", SqlDbType.NVarChar).Value = objCompanyDetail.ServiceTaxCSTTinNo;
                    cmd.ExecuteReader();
                }
            }
        }

        public static void InsertUpdateClientDetail(ClientDetail objClientDetail)
        {
            SqlConnection con = null;
            using (con = new SqlConnection(ConnectionModel.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("InsertUpdateClientDetail", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteReader();
                }
            }
        }
        public static List<GenericListBinder> GetCitiesByStateID(int stateID)
        {
            List<GenericListBinder> list = new List<GenericListBinder>();
            SqlConnection con = null;
            using (con = new SqlConnection(ConnectionModel.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetCitiesByStateID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@stateID", SqlDbType.Int).Value = stateID;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        list.Add(new GenericListBinder()
                        {
                            Name = rd.GetString("City")
                        });
                    }
                }
            }
            return list;
        }
        public static void InsertCompanyData(CompanyDetail companyDetail)
        {
            if (!String.IsNullOrEmpty(companyDetail.CompanyName))
            {
                companyDetail.CompanyName = companyDetail.CompanyName.Trim().Replace(' ', '_');
            }
            else
            {
                companyDetail.CompanName = "default";
            }

            string path = @"Userdata/gleambill.db";
            string destpath = @"" + companyDetail.CompanyName + "/gleambill.db";
            if (System.IO.File.Exists(System.IO.Path.Combine(Directory.GetCurrentDirectory(), path)))
            {
                File.Copy(System.IO.Path.Combine(Directory.GetCurrentDirectory(), path), System.IO.Path.Combine(Directory.GetCurrentDirectory(), destpath));
            }
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + destpath + ";Version=3;");
            m_dbConnection.Open();

            string sql = "insert into company_details(name, address, zip, city,email,telephone,website,logo,details,state_id,currency_id,tin,pan,stn,tax_label,service_category_id,gstin,tax_id_label) values ('Me', 9001)";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();
        }
    }
}
