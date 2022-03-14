using System.Collections.Generic;

namespace SoruceGenerator
{
    public class MessageParameter
    {
        public string Type;
        public string Name;
    }

    public class ExceptionParameter
    {
        public string Type;
        public string Name;
    }

    public class Exception
    {
        public string Name { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorCategory { get; set; }
        public string ErrorMessage { get; set; }
        public string ActionableErrorMessage { get; set; }
        public MessageParameter[] MessageParameters { get; set; }
        public ExceptionParameter[] ExceptionParameters { get; set; }
    }

    public class BaseException
    {
        public string Namespace;
        public string Name;
        public string FacilityCode;
        public string InheritsFrom;
        public List<Exception> Exceptions;
    }
}
