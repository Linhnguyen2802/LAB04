using Lab04.Helper;
using Lab04.Models;
using PredicateExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Lab04.Helper.SearchParameters;

namespace Lab04.Helper
{
    public class SearchBuilder
    {
        private IsearchParameters _searchParameters;
        public SearchBuilder() : this(new SearchParameters())
        {

        }
        public SearchBuilder(IsearchParameters searchParameters)
        {
            _searchParameters = searchParameters;
        }
        public SearchBuilder SetSearchTerm(string searchTerm)
        {
            _searchParameters.SearchTerm = searchTerm;
            return this;
        }
        public SearchBuilder SetCompany(List<string> company)
        {
            _searchParameters.Company = company;
            return this;
        }
        public SearchBuilder SetScreenResolution(List<string> screensolution)
        {
            _searchParameters.ScreenResolution = screensolution;
            return this;
        }
        public SearchBuilder SetSortBy(SortCriteria sortby)
        {
            _searchParameters.SortBy = sortby;
            return this;
        }
        public SearchBuilder SetTypeName(List<string> typename)
        {
            _searchParameters.TypeName = typename;
            return this;
        }
        public SearchBuilder SetInch(List<float> inches)
        {
            _searchParameters.Inches = inches;
            return this;
        }
        public SearchBuilder SetCPU(List<string> cpu)
        {
            _searchParameters.CPU = cpu;
            return this;
        }
        public SearchBuilder SetSpeed(List<float> speed)
        {
            _searchParameters.Speed = speed;
            return this;
        }
        public SearchBuilder SetMemory(List<string> memory)
        {
            _searchParameters.Memory = memory;
            return this;
        }
        public SearchBuilder SetRam(List<int> ram)
        {
            _searchParameters.Ram = ram;
            return this;
        }
        public SearchBuilder SetGPU(List<string> gpu)
        {
            _searchParameters.GPU = gpu;
            return this;
        }
        public SearchBuilder SetOS(List<string> os)
        {
            _searchParameters.OS = os;
            return this;
        }
        public SearchBuilder SetPriceHigh(double pricehigh)
        {
            _searchParameters.PriceHigh = pricehigh;
            return this;
        }
        public SearchBuilder SetPriceLow(double pricelow)
        {
            _searchParameters.PriceLow = pricelow;
            return this;
        }
        public SearchBuilder SetWeight(List<float> weight)
        {
            _searchParameters.Weight = weight;
            return this;
        }

        //-----------

        public IEnumerable<laptop> Build(FilterDbContext Entities)
        {
            var predicate = PredicateExtensions.PredicateExtensions.Begin<laptop>();
            //search term 
            if (!String.IsNullOrEmpty(_searchParameters.SearchTerm))
            {
                predicate = predicate.And(e => e.Product.Contains(_searchParameters.SearchTerm));
            }
            //price 

            if (_searchParameters.PriceLow > 0 && _searchParameters.PriceHigh > 0)
            {
                predicate = predicate.And(e => e.Price_euros >= _searchParameters.PriceLow && e.Price_euros <= _searchParameters.PriceHigh);
            }
            //company 
            if (_searchParameters.Company.Count > 0)
            {
                var temppredicate = PredicateExtensions.PredicateExtensions.Begin<laptop>();

                foreach (var item in _searchParameters.Company)
                {
                    temppredicate = temppredicate.Or(e => e.Company == item);
                }
                predicate = predicate.And(temppredicate);
            }
            //ScreenResolution 
            if (_searchParameters.ScreenResolution.Count > 0)
            {
                var temppredicate = PredicateExtensions.PredicateExtensions.Begin<laptop>();
                foreach (var item in _searchParameters.ScreenResolution)
                {
                    temppredicate = temppredicate.Or(e => e.ScreenResolution == item);
                }
                predicate = predicate.And(temppredicate);
            }
            if (_searchParameters.TypeName.Count > 0)
            {
                var temppredicate = PredicateExtensions.PredicateExtensions.Begin<laptop>();
                foreach (var item in _searchParameters.TypeName)
                {
                    temppredicate = temppredicate.Or(e => e.TypeName == item);
                }
                predicate = predicate.And(temppredicate);
            }
            //Inches 
            if (_searchParameters.Inches.Count > 0)
            {
                var temppredicate = PredicateExtensions.PredicateExtensions.Begin<laptop>();
                foreach (var item in _searchParameters.Inches)
                {
                    temppredicate = temppredicate.Or(e => e.Inches == item);
                }
                predicate = predicate.And(temppredicate);
            }
            //CPU 
            if (_searchParameters.CPU.Count > 0)
            {
                var temppredicate = PredicateExtensions.PredicateExtensions.Begin<laptop>();
                foreach (var item in _searchParameters.CPU)
                {
                    temppredicate = temppredicate.Or(e => e.Cpu == item);
                }
                predicate = predicate.And(temppredicate);
            }
            //Speed 
            if (_searchParameters.Speed.Count > 0)
            {
                var temppredicate = PredicateExtensions.PredicateExtensions.Begin<laptop>();
                foreach (var item in _searchParameters.Speed)
                {
                    temppredicate = temppredicate.Or(e => e.Speed == item);
                }
                predicate = predicate.And(temppredicate);
            }
            //Memory 
            if (_searchParameters.Memory.Count > 0)
            {
                var temppredicate = PredicateExtensions.PredicateExtensions.Begin<laptop>();
                foreach (var item in _searchParameters.Memory)
                {
                    temppredicate = temppredicate.Or(e => e.Memory == item);
                }
                predicate = predicate.And(temppredicate);
            }
            //Ram 
            if (_searchParameters.Ram.Count > 0)
            {
                var temppredicate = PredicateExtensions.PredicateExtensions.Begin<laptop>();
                foreach (var item in _searchParameters.Ram)
                {
                    temppredicate = temppredicate.Or(e => e.Ram == item);
                }
                predicate = predicate.And(temppredicate);
            }
            //GPU 
            if (_searchParameters.GPU.Count > 0)
            {
                var temppredicate = PredicateExtensions.PredicateExtensions.Begin<laptop>();
                foreach (var item in _searchParameters.GPU)
                {
                    temppredicate = temppredicate.Or(e => e.Gpu == item);
                }
                predicate = predicate.And(temppredicate);
            }
            if (_searchParameters.OS.Count > 0)
            {
                var temppredicate = PredicateExtensions.PredicateExtensions.Begin<laptop>();
                foreach (var item in _searchParameters.OS)
                {
                    temppredicate = temppredicate.Or(e => e.OpSys == item);
                }
                predicate = predicate.And(temppredicate);
            }
            //Weight 
            if (_searchParameters.Weight.Count > 0)
            {
                var temppredicate = PredicateExtensions.PredicateExtensions.Begin<laptop>();
                foreach (var item in _searchParameters.Weight)
                {
                    temppredicate = temppredicate.Or(e => e.Weight == item);
                }
                predicate = predicate.And(temppredicate);
            }
            var records = Entities.laptops.Where(predicate);
            switch (_searchParameters.SortBy)
            {
                case SortCriteria.Relevance:
                    break;
                case SortCriteria.PriceLowToHigh:
                    records = records.OrderBy(e => e.Price_euros);
                    break;
                case SortCriteria.PriceHighToLow:
                    records = records.OrderByDescending(e => e.Price_euros);
                    break;
                default:
                    break;
            }
            return records;

        

        }
    }
}