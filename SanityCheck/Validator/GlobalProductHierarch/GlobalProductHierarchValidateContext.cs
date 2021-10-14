using ReNameStoredProcedureSanityCheck.Validator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReNameStoredProcedure.SanityCheck.Validator.GlobalProductHierarch
{
    public class GlobalProductHierarchValidateContext : ISanityCheckValidateContext
    {
        public DataTable Data { get; set; }
    }
}
