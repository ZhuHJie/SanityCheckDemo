using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReNameStoredProcedureSanityCheck.FileSanityCheck
{
    public class FileSanityCheckException : SanityScheckException
    {
        public FileSanityCheckException(int row, string code, params object[] messageParams) : base(row, code, messageParams)
        {
        }
        public FileSanityCheckException(string message) : base(message)
        {
        }
        public FileSanityCheckException(string message, Exception innerException) : base(message, innerException)
        {
        }
        public FileSanityCheckException(int row, string code, Exception innerException, params object[] messageParams) : base(row, code, innerException, messageParams)
        {

        }
    }
}