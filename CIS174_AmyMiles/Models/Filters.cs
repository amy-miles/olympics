﻿namespace CIS174_AmyMiles.Models
{
    public class Filters
    {
        public Filters(string filterstring) 
        {
            FilterString = filterstring ?? "all";
            StatusId = FilterString;
        }
        public string FilterString { get; }
        public string StatusId { get; }

        public bool HasStatus => StatusId.ToLower() != "all";
    }
}
