using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;


namespace Lab04.Helper
{
    public class SearchParameters : IsearchParameters
    {
        public enum SortCriteria
        {
            [Description("Relevance")]
            Relevance = 0,
            [Description("Price: Low to High")]
            PriceLowToHigh = 1,
            [Description("Price: High to Low")]
            PriceHighToLow = 2
        }
        public SearchParameters()
        {
            SearchTerm = String.Empty;
            Company = new List<string>();
            ScreenResolution = new List<string>();
            SortBy = SortCriteria.Relevance;
            TypeName = new List<string>();
            Inches = new List<float>();
            CPU = new List<string>();
            Speed = new List<float>();
            Memory = new List<string>();
            Ram = new List<int>();
            GPU = new List<string>();
            OS = new List<string>();
            PriceLow = 0;
            PriceHigh = 0;
            Weight = new List<float>();
        }


        public string SearchTerm { get; set; }
        public List<string> Company { get; set; }
        public List<string> ScreenResolution { get; set; }
        public SortCriteria SortBy { get; set; }
        public List<string> TypeName { get; set; }
        public List<float> Inches { get; set; }
        public List<string> CPU { get; set; }
        public List<float> Speed { get; set; }
        public List<string> Memory { get; set; }
        public List<int> Ram { get; set; }
        public List<string> GPU { get; set; }
        public List<string> OS { get; set; }
        public double PriceLow { get; set; }
        public double PriceHigh { get; set; }
        public List<float> Weight { get; set; }

    }
}