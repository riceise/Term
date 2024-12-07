namespace Share.Validations
{
    public class CustomValidationException : Exception
    {
        public IEnumerable<string> Errors { get; }

        public CustomValidationException(IEnumerable<string> errors)
        {
            Errors = errors;
        }
    }
}

