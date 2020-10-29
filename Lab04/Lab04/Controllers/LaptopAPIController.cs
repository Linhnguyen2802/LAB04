using Lab04.Helper;
using Lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static Lab04.Helper.SearchParameters;

namespace Lab04.Controllers
{
    public class LaptopAPIController : ApiController
    {
        FilterDbContext db = new FilterDbContext();
        public IEnumerable<laptop> getAll()
        {
            var searchQuery = db.laptops;
            return searchQuery;
        }
        public IHttpActionResult GetProduct(string features_hash)
        {
            SearchParameters seacrhParameters = new SearchParameters();
            string[] ListQuery;
            ListQuery = features_hash.Split('_');
            foreach (var item in ListQuery)
            {
                string typeQuery = item.Split('-')[0];
                string QueryData = item.Split('-')[1];
                switch (typeQuery)
                {
                    case "1":
                        seacrhParameters.SearchTerm = QueryData;
                        break;
                    case "2":
                        seacrhParameters.Company.Add(QueryData);
                        break;
                    case "3":
                        seacrhParameters.ScreenResolution.Add(QueryData);
                        break;
                    case "4":
                        seacrhParameters.TypeName.Add(QueryData);
                        break;
                    case "5":
                        seacrhParameters.Inches.Add(float.Parse(QueryData));
                        break;
                    case "6":
                        seacrhParameters.CPU.Add(QueryData);
                        break;
                    case "7":
                        seacrhParameters.Speed.Add(float.Parse(QueryData));
                        break;
                    case "8":
                        seacrhParameters.Memory.Add(QueryData);
                        break;
                    case "9":
                        seacrhParameters.Ram.Add(Int32.Parse(QueryData));
                        break;
                    case "10":
                        seacrhParameters.GPU.Add(QueryData);
                        break;
                    case "11":
                        seacrhParameters.OS.Add(QueryData);
                        break;
                    case "12":
                        seacrhParameters.PriceLow = double.Parse(QueryData);
                        break;
                    case "13":
                        seacrhParameters.PriceHigh = double.Parse(QueryData);
                        break;
                    case "14":
                        seacrhParameters.Weight.Add(float.Parse(QueryData));
                        break;
                    case "15":
                        switch (QueryData)
                        {
                            case "1":
                                seacrhParameters.SortBy = SortCriteria.PriceHighToLow;
                                break;
                            case "2":
                                seacrhParameters.SortBy = SortCriteria.PriceLowToHigh;
                                break;
                            default:
                                seacrhParameters.SortBy = SortCriteria.Relevance;
                                break;
                        }
                        break;
                    default: 
                        break;
                }
            }
            var searchQuery = new SearchBuilder().
            SetSearchTerm(seacrhParameters.SearchTerm).//1 
            SetCompany(seacrhParameters.Company).//2 
            SetScreenResolution(seacrhParameters.ScreenResolution).//3 
            SetTypeName(seacrhParameters.TypeName).//4 
            SetInch(seacrhParameters.Inches).//5 
            SetCPU(seacrhParameters.CPU).//6 
            SetSpeed(seacrhParameters.Speed).//7 
            SetMemory(seacrhParameters.Memory).//8 
            SetRam(seacrhParameters.Ram).//9 
            SetGPU(seacrhParameters.GPU).//10 
            SetOS(seacrhParameters.OS).//11 
            SetPriceLow(seacrhParameters.PriceLow).//12 
            SetPriceHigh(seacrhParameters.PriceHigh).//13 
            SetWeight(seacrhParameters.Weight)//14 
            .SetSortBy(SortCriteria.PriceHighToLow)//15 
            .Build(db);
            return Ok(searchQuery);
        }
    }
}
