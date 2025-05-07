﻿using System.ComponentModel.DataAnnotations;

namespace session38_50.Models;

public class Product
{
    public int ProductID { get; set; }
    public int CategoryID { get; set; }
    
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = String.Empty;
    public string Description { get; set; }
    [Required(ErrorMessage = "Price is required")]
    [Range(0, 1000000, ErrorMessage = "Price must be between 0 and 1000000")]
    public decimal Price { get; set; }
    public decimal OriginalPrice { get; set; }
    public int Discount { get; set; }
    public int Stock { get; set; }
    public int Sold { get; set; }
    public decimal Rating { get; set; }
    public int ReviewCount { get; set; }
    public string Thumbnail { get; set; } = String.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}