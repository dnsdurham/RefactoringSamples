﻿using Refactoring.DataContracts;
using Refactoring.ResourceAccessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.ManagerTests.Mocks
{
    class MockCustomerAccessor : ICustomerAccessor
    {
        public Customer GetCustomerById(int customerId)
        {

            // hardcoded to provide sample data
            // I realize this is exactly the same as the actual Customer Accessor but this is more representative
            // of what a mock accessor would look and the actual Customer Accessor would be using an actual 
            // customer database
            return new Customer
            {
                Name = "Gern Blansten",
                Rentals = SetupSampleRentals()
            };
        }

        Rental[] SetupSampleRentals()
        {
            List<Rental> rentals = new List<Rental>();
            rentals.Add(new Rental { MovieName = "Jaws", DaysRented = 2, PriceCode = PriceCodeType.Regular });
            rentals.Add(new Rental { MovieName = "Star Wars", DaysRented = 3, PriceCode = PriceCodeType.Regular });
            rentals.Add(new Rental { MovieName = "Toy Story", DaysRented = 4, PriceCode = PriceCodeType.Childrens });
            rentals.Add(new Rental { MovieName = "Wall-E", DaysRented = 3, PriceCode = PriceCodeType.Childrens });
            rentals.Add(new Rental { MovieName = "Thor", DaysRented = 1, PriceCode = PriceCodeType.NewRelease });
            rentals.Add(new Rental { MovieName = "Superman", DaysRented = 2, PriceCode = PriceCodeType.NewRelease });

            return rentals.ToArray();
        }
    }
}
