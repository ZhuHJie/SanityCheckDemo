using ReNameStoredProcedureSanityCheck.LoadData;
using ReNameStoredProcedureSanityCheck.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReNameStoredProcedureSanityCheck
{
    public abstract class SanityCheckBase<TCheckOption, TModel, TCheckResult> : ISanityCheck<TCheckOption, TCheckResult> where TCheckResult : class where TCheckOption : ISanityCheckOption where TModel : class
    {
        public SanityCheckBase(ILoadData<TCheckOption, TModel> loadData, TCheckOption option)
        {
            _loadData = loadData;
            _option = option;
            Validators = AddValidators();
        }
        public int CurrentRow { get; set; }
        protected List<ISanityCheckValidator<TModel>> Validators { get; private set; }
        protected ILoadData<TCheckOption, TModel> _loadData { get; }
        protected virtual IDictionary<int, string> SanityCheckLog { get; set; } = new Dictionary<int, string>();
        public abstract string SrcName { get; }

        public virtual TCheckOption Option => _option;

        private TCheckOption _option { get; }

        public abstract bool ChackAndSave(out TCheckResult result);

        public abstract bool Save(TModel model);

        public abstract List<ISanityCheckValidator<TModel>> AddValidators();

        public virtual string WriteSanityCheckLog()
        {
            if (SanityCheckLog.Any())
            {
                //TODO 写入日志
                return "";
            }
            else
            {
                return null;
            }
        }

        protected virtual void AddLog(int row, string message)
        {
            if (SanityCheckLog.ContainsKey(row))
            {
                SanityCheckLog[row] = message;
            }
            SanityCheckLog.Add(row, message);
        }



    }
}