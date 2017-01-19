using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using TipCalculatorDataAccessLayer.Model;
using TipCalculatorDataAccessLayer.Repository;


namespace TipCalculatorDataAccess
{
    public class TipCalculatorDAL
    {
        private ITipCalculatorRepository _repo;

        public TipCalculatorDAL(ITipCalculatorRepository repo)
        {
            _repo = repo;
        }
        /// <summary>
        /// Returns all countries
        /// </summary>
        /// <returns>list of country names</returns>
        public List<Country> GetCountries()
        {
            return _repo.GetCountries().ToList();
        }

        /// <summary>
        /// Returns the common percentage of the bill which is tipped in the specified country.
        /// </summary>
        /// <param name="country">country name</param>
        /// <returns>tip percentage >= 0</returns>
        public double GetTipPercentage(string country)
        {
            return _repo.GetCountries().FirstOrDefault(c => c.Name == country).TipPercentage;
        }

        /// <summary>
        /// Returns the multiplication factor for the delivered quality of service.
        /// </summary>
        /// <param name="qualityOfService">description of quality of service</param>
        /// <returns>multiplication factor for tip amount</returns>
        public double GetFactorQualityOfService(string qualityOfService)
        {
            if (qualityOfService == "Good")
                return (double)1.2;
            if (qualityOfService == "Average")
                return 0.8;
            if (qualityOfService == "Bad")
                return 0.4;
            return 0.1;

        }

        /// <summary>
        /// Returns the multiplication factor for the number of courses.
        /// </summary>
        /// <param name="numberOfCourses">number of courses ordered</param>
        /// <returns>multiplication factor for tip amount</returns>
        public double GetFactorNumberOfCourses(int numberOfCourses)
        {
            if (numberOfCourses == 0)
                return (double)1.2;
            if (numberOfCourses == 1)
                return 0.8;
            if (numberOfCourses == 2)
                return 0.4;
            return 0.1;

        }

        /// <summary>
        /// Returns the multiplication factor for the number of flies in soup.
        /// </summary>
        /// <param name="numberOfCourses">number of flies in soup encountered</param>
        /// <returns>multiplication factor for tip amount</returns>
        public double GetFactorNumberOfFlies(int numberOfFlies)
        {
            if (numberOfFlies == 0)
                return (double)1.2;
            if (numberOfFlies == 1)
                return 0.8;
            if (numberOfFlies == 2)
                return 0.4;
            return 0.1;
        }

        /// <summary>
        /// Gets the currency symbol of the specified country.
        /// </summary>
        /// <param name="country">country name</param>
        /// <returns></returns>
        public string GetCurrencySymbol(string country)
        {

            return _repo.GetCountries().FirstOrDefault(c => c.Name == country).Currency.Symbol;

        }

        /// <summary>
        /// Gets the exchange rate (compared to euro) for the country.
        /// </summary>
        /// <param name="country">country name</param>
        /// <returns>conversion ratio to euro</returns>
        public double GetExchangeRate(string country)
        {
            return _repo.GetCountries().FirstOrDefault(c => c.Name == country).Currency.ExchangeRate;
        }

        #region Private methods

        private string NumberToText(int number)
        {
            switch (number)
            {
                case 0:
                    return "Zero";
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                default:
                    throw new ArgumentException("Undefined number");
            }
        }

        private int TextToNumber(string number)
        {
            if (number == "Zero")
                return 0;
            else if (number == "One")
                return 1;
            else if (number == "Two")
                return 2;
            else if (number == "Three")
                return 3;
            else if (number == "Four")
                return 4;
            else
                throw new ArgumentException("Undefined number");
        }
        #endregion
    }
}
