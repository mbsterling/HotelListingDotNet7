namespace HotelListing.API.Core.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key) : 
            base($"Name {name} with id ({key}) was not found.")
        {

        }
    }
}
