using ReNameStoredProcedureSanityCheck.LoadData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ReNameStoredProcedureSanityCheck.DbCheck.GlobalProductHierarch
{
    public class GlobalProductHierarchLoadData : ILoadData<GlobalProductHierarchOption, DataTable>
    {
        public GlobalProductHierarchLoadData()
        {
            //TODO generate db mapping
            DbFieldMapping = new Dictionary<string, string>();
        }
        public bool TryLoad(GlobalProductHierarchOption input, out DataTable result)
        {
            //TODO get DataTable
            throw new NotImplementedException();
        }

        public IDictionary<string, string> DbFieldMapping { get; private set; }
    }
}