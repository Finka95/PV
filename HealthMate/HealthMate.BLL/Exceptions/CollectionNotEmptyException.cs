namespace HealthMate.BLL.Exceptions
{
    public class CollectionNotEmptyException : Exception
    {
        public CollectionNotEmptyException() { }

        public CollectionNotEmptyException(string message) : base(message) { }

        public CollectionNotEmptyException(string message, Exception inner) : base(message, inner) { }
    }
}
