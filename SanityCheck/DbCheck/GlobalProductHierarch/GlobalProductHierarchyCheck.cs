using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ReNameStoredProcedureSanityCheck.DbCheck.GlobalProductHierarch
{
    public class GlobalProductHierarchyCheck : DbSanityCheckBase<GlobalProductHierarchOption, DataTable>
    {
        public GlobalProductHierarchyCheck(GlobalProductHierarchLoadData loadData, GlobalProductHierarchOption option) : base(loadData, option)
        {

        }
        public override string SrcName => "GlobalProductHierarchy";

        public override bool Save(DataTable model)
        {
            //TODO 保存
            throw new NotImplementedException();
        }
    }
}