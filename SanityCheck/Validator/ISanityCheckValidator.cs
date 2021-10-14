using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReNameStoredProcedureSanityCheck.Validator
{
    public interface ISanityCheckValidator<TObject> where TObject : class
    {
        ISanityCheckValidateContext _context { get; set; }
        void InitContext(TObject contextInput);

        bool TryValidate(out SanityCheckValidateResult validateResult);
    }

}
