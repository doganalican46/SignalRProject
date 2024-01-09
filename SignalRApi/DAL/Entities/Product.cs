﻿namespace SignalRApi.DAL.Entities
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public bool Status { get; set; }

    }
}
