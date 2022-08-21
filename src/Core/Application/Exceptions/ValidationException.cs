namespace Application.Exceptions
{
    public class ValidationException:Exception
    {
        public ValidationException():this("Validation Error Ocurred")
        {

        }
        public ValidationException(string message) : base(message)
        {

        }
        public ValidationException(Exception ex) : this(ex.Message)
        {

        }
    }
}
