using HotelListing.API.Data;
using HotelListing.API.Core.Models.Country;

namespace HotelListing.API.Core.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        public Task<CountryDto> GetDetails(int id);
    }
}
