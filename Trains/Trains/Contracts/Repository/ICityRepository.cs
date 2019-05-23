using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trains.Model;

namespace Trains.Contracts.Repository
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> GetAllCities();

        Task<City> GetCityById(int cityId);
    }
}
