using CallApp.Domain.Respons.Data.Abstraction;

namespace CallApp.Domain.Respons.Data.Implementation
{
    public class DataResponse : IDataResponse
    {
        public string Message { get; set; }
        public bool IsError { get; set; }
    }
    public class DataResponse<T> : IDataResponse<T>
    {
        public T Data { get; set; }
        public bool IsError { get; set; }
        public string Message { get; set; }
    }
}