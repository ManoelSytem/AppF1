﻿using F1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Services.Ergast
{
    public interface IErgastService
    {
        Task<List<DriverStadingsModel>> GetDriverStadings(string year, string queryParams = null);
        Task<DriverModel> GetDriverInformations(string driver);
        Task<List<ConstructorStadingsModel>> GetTeamStadings(string year, string queryParams = null);
        Task<ConstructorModel> GetTeamInformations(string team);
        Task<ScheduleModel> GetSchedule(string year, string queryParams = null);
        Task<RaceEventModel> GetRaceEventInformations(string year, int round);
        Task<List<RaceEventModel>> GetResults(string year, string round, string raceType, string queryParams = null);
        Task<List<RaceEventModel>> GetResultsByDriver(string year, string driver);
        Task<List<RaceEventModel>> GetResultsByTeam(string year, string team);
        Task<List<RaceResultsLapByLapModel>> GetResultsLapByLap(string year, int round, string driver);
    }
}
