using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TipCalculatorDataAccessLayer.Model;

namespace TipCalculatorDataAccessLayer.Repository
{
    public class TipCalculatorRepository : ITipCalculatorRepository
    {
        public IEnumerable<Country> GetCountries()
        {
            return new Country[]
            {
                new Country() {Id = Guid.NewGuid(), Name = "United States", TipPercentage = 20, Currency = GetcurCurrencies().FirstOrDefault(c => c.Name=="Dollar")},
                new Country() {Id = Guid.NewGuid(), Name = "France", TipPercentage = 1, Currency = GetcurCurrencies().FirstOrDefault(c => c.Name=="Euro")},
                new Country() {Id = Guid.NewGuid(), Name = "Netherlands", TipPercentage = 0, Currency = GetcurCurrencies().FirstOrDefault(c => c.Name=="Euro")},
                new Country() {Id = Guid.NewGuid(), Name = "Japan", TipPercentage = 10, Currency = GetcurCurrencies().FirstOrDefault(c => c.Name=="Yen")},
            };
        }

        public IEnumerable<Currency> GetcurCurrencies()
        {
            return new Currency[]
            {
                new Currency(){ExchangeRate = 0.9, Name = "Dollar",Symbol = "$", Id = Guid.NewGuid()}, 
                new Currency(){ExchangeRate = 0.1, Name = "Euro",Symbol = "€", Id = Guid.NewGuid()},
                new Currency(){ExchangeRate = 0.01, Name = "Yen",Symbol = "¥", Id = Guid.NewGuid()},
            };
        }

        public IEnumerable<Setting> GetSettings()
        {
            return new Setting[]
            {

            };

        }
    }

    public interface ITipCalculatorRepository
    {
        IEnumerable<Country> GetCountries();
        IEnumerable<Currency> GetcurCurrencies();
        IEnumerable<Setting> GetSettings();
    }
}
