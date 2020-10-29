using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab04.Helper.SearchParameters;

namespace Lab04.Helper
{
    public interface IsearchParameters
    {
        string SearchTerm { get; set; }
        List<string> Company { get; set; }
        List<string> ScreenResolution { get; set; }
        SortCriteria SortBy { get; set; }
        List<string> TypeName { get; set; }
        List<float> Inches { get; set; }
        List<string> CPU { get; set; }
        List<float> Speed { get; set; }
        List<string> Memory { get; set; }
        List<int> Ram { get; set; }
        List<string> GPU { get; set; }
        List<string> OS { get; set; }
        double PriceLow { get; set; }
        double PriceHigh { get; set; }
        List<float> Weight { get; set; }
    }
}
