using AngularClinicDemo.data;
using AngularClinicDemo.Models;
using AutoMapper;

namespace AngularClinicDemo.Services
{
    public class CountryService: ICountryService
    {
        private readonly ClinicContext context;
        private readonly IMapper mapper;

        public CountryService(ClinicContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }
        public void Create(CountryDTO countryDTO)
        {

            Country newCountry = mapper.Map<Country>(countryDTO);

            context.Countries.Add(newCountry);
            context.SaveChanges();

        }

        public void Update(CountryDTO countryDTO)
        {

            Country newCountry = mapper.Map<Country>(countryDTO);
            context.Countries.Attach(newCountry);
            context.Entry(newCountry).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

        }

        public void Delete(int Id)
        {

            Country newCountry = context.Countries.Find(Id);

            context.Countries.Remove(newCountry);
            context.SaveChanges();

        }

        public List<CountryDTO> getAll()
        {

            List<Country> allCountries=context.Countries.ToList();

            List<CountryDTO> countries = mapper.Map<List<CountryDTO>>(allCountries);

            return countries;


        }

        public CountryDTO get(int Id)
        {

            Country country = context.Countries.Find(Id);

            CountryDTO countryDTO = mapper.Map<CountryDTO>(country);

            return countryDTO;


        }
    }
}
