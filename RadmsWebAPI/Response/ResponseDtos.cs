namespace RadmsWebAPI.Response
{
    public class ResponseDtos
    {
        public ResponseDtos()
        {

        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
