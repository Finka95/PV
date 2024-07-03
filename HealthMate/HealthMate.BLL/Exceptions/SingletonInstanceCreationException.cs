namespace HealthMate.BLL.Exceptions
{
    public class SingletonInstanceCreationException : Exception
    {
        public SingletonInstanceCreationException() { }

        public SingletonInstanceCreationException(string message) : base(message) { }

        public SingletonInstanceCreationException(string message, Exception inner) : base(message, inner) { }
    }
}
