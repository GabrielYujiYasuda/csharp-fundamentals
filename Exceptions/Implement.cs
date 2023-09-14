namespace Exceptions
{
    public class Implement : Exception
    {
        public DateTime WhenHappened { get; set; }

        public Implement(DateTime dateTime)
        {
            WhenHappened = dateTime;
        }
    }
}