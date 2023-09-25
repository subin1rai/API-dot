using SomethingAPI.Models;

namespace SomethingAPI.Interfaces
{
    public interface ICountryRepository
    {
        List<Country> GetAll();
        Country GetById(int id);
        void AddCountry(Country country);
        void UpdateCountry(Country country);
        void DeleteCountry(Country country);

    }
}
