using ReNameStoredProcedureSanityCheck.LoadData;
using ReNameStoredProcedureSanityCheck.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReNameStoredProcedureSanityCheck.DbCheck
{
    public abstract class DbSanityCheckBase<TCheckOption, TModel> : SanityCheckBase<TCheckOption, TModel, DbSanityCheckResult> where TCheckOption : ISanityCheckOption where TModel : class
    {
        public DbSanityCheckBase(ILoadData<TCheckOption, TModel> loadData, TCheckOption option) : base(loadData, option)
        {

        }

        public override List<ISanityCheckValidator<TModel>> AddValidators()
        {
            return new List<ISanityCheckValidator<TModel>>();
        }

        public override bool ChackAndSave(out DbSanityCheckResult result)
        {
            try
            {
                result = new DbSanityCheckResult();
                if (!_loadData.TryLoad(Option, out TModel data))
                {
                    AddLog(CurrentRow, $"{SrcName} can load data");
                    return false;
                }
                if (Validators.Any())
                {
                    foreach (var validator in Validators)
                    {
                        validator.InitContext(data);
                        if (!validator.TryValidate(out SanityCheckValidateResult validateResult))
                        {
                            AddLog(validateResult.RowNumber, string.Join(";", validateResult.Message));
                            return false;
                        }
                    }
                }

                var saveSuccess = Save(data);

                return saveSuccess;
            }
            catch (Exception ex)
            {
                AddLog(CurrentRow, ex.ToString());
                throw new DbSanityCheckException("check error", ex);
            }
            finally
            {
                WriteSanityCheckLog();
            }

        }

    }
}