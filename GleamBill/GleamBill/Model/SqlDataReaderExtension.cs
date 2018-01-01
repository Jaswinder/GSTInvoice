using System;
using System.Data.SqlClient;

namespace GleamBill.Model
{
    static class SqlDataReaderExtension
    {
        public static bool GetBoolean(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex))
            {
                return false;
            }
            else
            {
                return reader.GetBoolean(colIndex);
            }
        }
        public static bool? GetNullableBoolean(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex))
            {
                return null;
            }
            else
            {
                return reader.GetBoolean(colIndex);
            }
        }
        public static DateTime GetDateTime(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex))
            {
                return DateTime.MinValue;
            }
            else
            {
                return reader.GetDateTime(colIndex);
            }
        }

        public static double GetDouble(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex))
            {
                return Double.NaN;
            }
            else
            {
                return reader.GetDouble(colIndex);
            }
        }

        public static Guid GetGuid(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex))
            {
                return Guid.Empty;
            }
            else
            {
                return reader.GetGuid(colIndex);
            }
        }

        public static byte? GetNullableByte(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex))
            {
                return null;
            }
            else
            {
                return reader.GetByte(colIndex);
            }
        }

        public static Int16? GetNullableInt16(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex))
            {
                return null;
            }
            else
            {
                return reader.GetInt16(colIndex);
            }
        }
        public static Int16 GetInt16(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex))
            {
                return 0;
            }
            else
            {
                return reader.GetInt16(colIndex);
            }
        }

        public static int GetInt32(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex))
            {
                return 0;
            }
            else
            {
                return reader.GetInt32(colIndex);
            }
        }
        public static int? GetNullableInt32(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex))
            {
                return null;
            }
            else
            {
                return reader.GetInt32(colIndex);
            }
        }
        public static Int64? GetNullableInt64(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex))
            {
                return null;
            }
            else
            {
                return reader.GetInt64(colIndex);
            }
        }

        public static string GetString(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex))
            {
                return null;
            }
            else
            {
                return reader.GetString(colIndex);
            }
        }

        public static int GetInt32FromString(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (reader.IsDBNull(colIndex) || reader.GetString(colIndex).Trim() == string.Empty)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(reader.GetString(colIndex).Trim());
            }
        }
    }
}
