using ReNameStoredProcedureSanityCheck.Validator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReNameStoredProcedure.SanityCheck.Validator.GlobalProductHierarch
{
    public class GlobalProductHierarchValidator : ISanityCheckValidator<DataTable>
    {
        public ISanityCheckValidateContext _context { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private GlobalProductHierarchValidateContext Context { get => _context as GlobalProductHierarchValidateContext; }
        public void InitContext(DataTable contextInput)
        {
            _context = new GlobalProductHierarchValidateContext();
        }

        public bool TryValidate(out SanityCheckValidateResult validateResult)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
