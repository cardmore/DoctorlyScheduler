namespace Doctorly.Services.Common
{
    [Serializable]
    public class ServiceError
    {
        public ServiceError(string message, int code)
        {
            this.Message = message;
            this.Code = code;
        }

        public ServiceError() { }

        public string Message { get; }
        public int Code { get; }
        public static ServiceError DefaultError => new ServiceError("An exception occured.", 999);
    }
}
