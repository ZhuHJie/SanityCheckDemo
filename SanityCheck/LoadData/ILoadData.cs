using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReNameStoredProcedureSanityCheck.LoadData
{
    public interface ILoadData<TLoadOption, TModel> where TLoadOption : ISanityCheckOption where TModel : class
    {
        bool TryLoad(TLoadOption input, out TModel result);
    }
}
