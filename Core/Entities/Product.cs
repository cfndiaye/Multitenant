﻿using System;
using Core.Contracts;

namespace Core.Entities
{
    public class Product : BaseEntity, IMustHaveTenant
    {
        public Product(string name, string description, int rate)
        {
            Name = name;
            Description = description;
            Rate = rate;
        }
        public Product()
        {

        }

        public string TenantId { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Rate { get; private set; }
    }
}
