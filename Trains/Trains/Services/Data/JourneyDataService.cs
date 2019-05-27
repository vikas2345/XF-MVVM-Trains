using System;
using System.Collections.Generic;
using System.Text;
using Trains.Contracts.Repository;

namespace Trains.Services.Data
{
    public class JourneyDataService : IJourneyDataService
    {
        private readonly IJourneyRepository _journeyRepository;
        private readonly ICityRepository _cityRepository;

        public JourneyDataService( IJourneyRepository journeyRepository, ICityRepository cityRepository)
        {
            _journeyRepository = journeyRepository;
            _cityRepository = cityRepository;
        }
    }
}

