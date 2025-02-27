﻿namespace Pezza.Test
{
    using System;
    using Bogus;
    using Pezza.Common.DTO;
    using Pezza.Common.Models.Base;

    public static class RestaurantTestData
    {
        public static Faker faker = new ();

        public static RestaurantDTO RestaurantDTO = new ()
        {
            Name = faker.Company.CompanyName(),
            Description = string.Empty,
            PictureUrl = string.Empty,
            Address = new AddressBase
            {
                Address = faker.Address.FullAddress(),
                City = faker.Address.City(),
                PostalCode = faker.Address.ZipCode(),
                Province = faker.Address.State(),
            },
            DateCreated = DateTime.Now,
            IsActive = true
        };
    }
}
