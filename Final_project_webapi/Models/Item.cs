﻿namespace Final_project_webapi.Models
{
    public class Item
    {
        
        public int itemId { get; set; }
        public string? itemName { get; set; }
        public string? description { get; set; }
        public int? quantity { get; set; }
        public string? Flavor { get; set; }
    }
}
