using AngularClinicDemo.data;
using AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace AngularClinicDemo.Models
{
    [AutoMap(typeof(Country),ReverseMap =true)]
    public class CountryDTO
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
