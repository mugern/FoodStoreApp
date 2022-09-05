﻿using System.ComponentModel.DataAnnotations;

namespace FoodStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
