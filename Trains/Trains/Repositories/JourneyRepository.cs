using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trains.Contracts.Repository;
using Trains.Model;

namespace Trains.Repositories
{
    public class JourneyRepository:BaseRepository, IJourneyRepository
    {
        private static readonly List<Journey> AllJourneys = new List<Journey>()
        {
            new Journey
            {
                JourneyId = 1,
                FromCityId = 1,
                ToCityId  = 2,
                DepartureTime = DateTime.Now.AddHours(1),
                ArrivalTime = DateTime.Now.AddHours(2),
                JourneyDate = DateTime.Now,
                Platform = "12",
                Price = 50
            },
            new Journey
            {
                JourneyId = 2,
                FromCityId = 2,
                ToCityId = 1,
                DepartureTime = DateTime.Now.AddHours(2),
                ArrivalTime = DateTime.Now.AddHours(3),
                JourneyDate = DateTime.Now,
                Platform = "6",
                Price = 100
            },
            new Journey
            {
                JourneyId = 3,
                FromCityId = 1,
                ToCityId = 2,
                DepartureTime = DateTime.Now.AddHours(4),
                ArrivalTime = DateTime.Now.AddHours(5),
                JourneyDate = DateTime.Now,
                Platform = "6",
                Price = 100
            },
            new Journey
            {
                JourneyId = 4,
                FromCityId = 1,
                ToCityId = 2,
                DepartureTime = DateTime.Now.AddHours(6),
                ArrivalTime = DateTime.Now.AddHours(7),
                JourneyDate = DateTime.Now,
                Platform = "6",
                Price = 100
            }
        };

        public async Task<Journey> GetJourneyDetails(int journeyId)
        {
            return await Task.FromResult(AllJourneys.FirstOrDefault(j => j.JourneyId == journeyId));
        }

        public async Task<IEnumerable<Journey>> SearchJourney(int fromCity, int toCity, DateTime journeyDate, DateTime departureTime)
        {
            return await Task.FromResult(AllJourneys.Where(fr => fr.FromCityId == fromCity && fr.ToCityId == toCity));
        }
    }
}
