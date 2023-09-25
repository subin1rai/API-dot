using SomethingAPI.Data;
using SomethingAPI.Interfaces;
using SomethingAPI.Models;

namespace SomethingAPI.Implementation
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDbContext _context;
        public CountryRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddCountry(Country country)
        {
            _context.Country.Add(country);
            _context.SaveChanges();
        }

        public void DeleteCountry(Country country)
        {
            _context.Country.Remove(country);
            _context.SaveChanges();
        }

        public List<Country> GetAll()
        {
            var allCountry = _context.Country.ToList();
            return allCountry;
        }

        public Country GetById(int id)
        {
            var country = _context.Country.FirstOrDefault(x=>x.Id == id);
            return country;
        }

        public void UpdateCountry(Country country)
        {
           _context.Country.Update(country);
            _context.SaveChanges();
        }
    }
}
