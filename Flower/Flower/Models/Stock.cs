using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

//Модель Склада

namespace Flower.Models
{
    public class Stock
    {
        public Guid Id { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }// Название склада
    }
}