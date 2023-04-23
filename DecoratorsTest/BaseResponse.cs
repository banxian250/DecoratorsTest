namespace DecoratorsTest
{
    public class BaseResponse<T>
    {
        public BaseResponse(string code, string msg, T data)
        {
            Code = code;
            Msg = msg;
            Data = data;
        }

        public string Code { get; set; }
        public string Msg { get; set; }
        public T Data { get; set; }
    }
}
