using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorLogger
{
    public static class LogExtensions
    {
        public static string LineNumber(this Exception ex)
        {
            try
            {
                var lineNumber = 0;
                const string lineSearch = ":line ";
                var index = ex.StackTrace.LastIndexOf(lineSearch);
                if (index != -1)
                {
                    var lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length);
                    int.TryParse(lineNumberText, out lineNumber);
                }
                return Convert.ToString(lineNumber);
            }
            catch (Exception ex1)
            {
                Log.Write(LOGTYPE.GLEAMBILLERROR, "Method Name: Extention Method of MyExtensions() LineNumber(), Error Message:" + ex1.Message);
                return "0";
            }
        }
    }
}
