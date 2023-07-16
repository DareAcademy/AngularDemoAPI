using AngularClinicDemo.Models;
using AngularClinicDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularClinicDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService countryService;

        public CountryController(ICountryService _CountryService)
        {
            countryService = _CountryService;
        }

        [HttpPost]
        public void Insert(CountryDTO countryDTO)
        {
            countryService.Create(countryDTO);
        }

        [HttpPut]
        public void Update(CountryDTO countryDTO)
        {
            countryService.Update(countryDTO);
        }

        [HttpDelete]
        public void Delete(int Id)
        {
            countryService.Delete(Id);
        }

        [HttpGet]
        [Route("LoadAll")]
        public List<CountryDTO> LoadAll()
        {
            return countryService.getAll();
        }

        [HttpGet]
        [Route("Load")]
        public CountryDTO Load(int Id)
        {
            return countryService.get(Id);
        }
    }
}
