using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReNameStoredProcedureSanityCheck.Validator
{
    public class SanityCheckValidateResult
    {
        internal List<string> Message { get; set; }
        internal string MemberName { get; set; }
        internal int RowNumber { get; set; }
    }
}
