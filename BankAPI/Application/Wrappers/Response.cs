namespace Application.Wrappers
{
    public class Response<T>
    {
        public Response()
        {

        }
        public Response(T data, string message)
        {
            Succeded = true;
            Message = message;
            Data = data;

        }

        public Response(string message)
        {
            Succeded = false;
            Message = message;
        }

        public Response(int value)
        {

        }

        public bool? Succeded { get; set; }
        public string? Message { get; set; }
        public List<string>? Errors { get; set; }
        public T? Data { get; set; }
    }
}
