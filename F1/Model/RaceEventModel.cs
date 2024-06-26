﻿using System;
using System.Collections.Generic;

namespace F1.Models
{
    public record RaceEventModel
    {
        public int Round { get; set; }
        public string RaceName { get; set; }
        public CircuitModel Circuit { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public EventModel FirstPractice { get; set; }
        public EventModel SecondPractice { get; set; }
        public EventModel ThirdPractice { get; set; }
        public EventModel Qualifying { get; set; }
        public EventModel Sprint { get; set; }
        public List<RaceResultModel> Results { get; set; }
        public List<QualifyingResultModel> QualifyingResults { get; set; }
        public List<RaceResultModel> SprintResults { get; set; }
    }
}
