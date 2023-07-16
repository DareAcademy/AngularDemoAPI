using AngularClinicDemo.Models;

namespace AngularClinicDemo.Services
{
    public interface ICountryService
    {
        void Create(CountryDTO countryDTO);

        List<CountryDTO> getAll();

        void Delete(int Id);

        CountryDTO get(int Id);

        void Update(CountryDTO countryDTO);
    }
}
