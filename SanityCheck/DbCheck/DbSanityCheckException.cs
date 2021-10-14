using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReNameStoredProcedureSanityCheck.DbCheck
{
    public class DbSanityCheckException : SanityScheckException
    {
        public DbSanityCheckException(int row, string code, params object[] messageParams) : base(row, code, messageParams)
        {
        }
        public DbSanityCheckException(string message) : base(message)
        {
        }
        public DbSanityCheckException(string message, Exception innerException) : base(message, innerException)
        {
        }
        public DbSanityCheckException(int row, string code, Exception innerException, params object[] messageParams) : base(row, code, innerException, messageParams)
        {

        }
    }
}