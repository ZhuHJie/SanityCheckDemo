using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReNameStoredProcedureSanityCheck
{
    public class SanityScheckException : Exception
    {
        public int CurrentRow { get; set; }
        public string Code { get; set; }
        public object[] MessageParams { get; set; }
        private SanityScheckExceptionMessage _sanityScheckExceptionMessage { get; set; } = new SanityScheckExceptionMessage();
        private string message => _sanityScheckExceptionMessage.L(Code, MessageParams);
        public override string Message => string.IsNullOrEmpty(message) ? message : base.Message;
        public SanityScheckException(int row, string code, params object[] messageParams)
        {
            CurrentRow = row;
            Code = code;
            MessageParams = messageParams;
        }
        public SanityScheckException(int row, string code, Exception innerException, params object[] messageParams) : this(null, innerException)
        {
            CurrentRow = row;
            Code = code;
            MessageParams = messageParams;
        }
        public SanityScheckException(string message, Exception innerException) : base(message, innerException)
        {

        }
        public SanityScheckException(string message) : base(message)
        {
        }
    }

    public abstract class ExceptionMessage
    {
        public abstract Dictionary<string, string> Message { get; }


        public string L(string code, params object[] parameters)
        {
            if (Message.TryGetValue(code, out string message))
            {
                return string.Format(message, parameters);
            }
            return null;
        }
    }

    public class SanityScheckExceptionMessage : ExceptionMessage
    {
        public SanityScheckExceptionMessage()
        {
            _messageMap = new Dictionary<string, string>();
        }

        private Dictionary<string, string> _messageMap { get; set; }
        public override Dictionary<string, string> Message { get => _messageMap; }
    }
}