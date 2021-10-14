using ReNameStoredProcedureVmWroking;

namespace ReNameStoredProcedureSanityCheck
{
    public interface ISanityCheck<TCheckOption, TCheckResult> : ISanityCheck<TCheckResult> where TCheckOption : ISanityCheckOption where TCheckResult : class
    {
        TCheckOption Option { get; }
    }
    public interface ISanityCheck<TCheckResult> where TCheckResult : class
    {
        bool ChackAndSave(out TCheckResult result);
        string SrcName { get; }
    }
}
