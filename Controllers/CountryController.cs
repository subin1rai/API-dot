using Microsoft.AspNetCore.Mvc;
using SomethingAPI.Interfaces;
using SomethingAPI.Models;

namespace SomethingAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        public ICountryRepository _countryRepository;
        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        [HttpGet("allCountries")]
        public IActionResult GetCountries() {
            var allCountries = _countryRepository.GetAll();
            return Ok(allCountries);
        }

        [HttpPost("AddCountry")]
        public IActionResult AddCountry(Country country)
        {
            if (country == null)
            {
                return BadRequest(ModelState);
            }
            _countryRepository.AddCountry(country);
            return Ok(country);
        }

        [HttpGet("GetCountryById")]
        public IActionResult GetCountryById(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            var country = _countryRepository.GetById(id);
            return Ok(country);
        }

        [HttpPost("UpdateCountries")]
        public IActionResult UpdateCountry(Country country) {
            _countryRepository.UpdateCountry(country);
            return Ok(country);
        }

        [HttpPost("DeleteCountry")]
        public IActionResult DeleteACountry(Country country) {
            _countryRepository.DeleteCountry(country);
            return Ok();
        }

    }
}
