using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trains.Model;

namespace Trains.Contracts.Repository
{
    public interface IJourneyRepository
    {
        Task<IEnumerable<Journey>> SearchJourney(int fromCity, int toCity, DateTime journeyDate, DateTime departureTime);

        Task<Journey> GetJourneyDetails(int journeyId);
    }
}
