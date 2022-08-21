namespace Application.Wrappers
{
    public class BaseResponse
    {
        public Guid Id{ get; set; }
        public bool Succes { get; set; }
        public string Message{ get; set; }
    }
}
