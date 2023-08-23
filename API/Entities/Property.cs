﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Property
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        [MaxLength(30)]
        public string Address { get; set; }
        [Required]
        [MaxLength(30)]
        public string Tipology { get; set; }
        public string Floor { get; set; }
        public string Division { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Elevator { get; set; }
        [Required]
        [MaxLength(1000)]
        public string PaymentPeriodicy { get; set; }
        public decimal Price { get; set; }
        //[ForeignKey("Owner")]
        //public int OwnerId { get; set; }
        //public Owner Owner { get; set; }
        //[ForeignKey("County")]
        //public int CountyId { get; set; }
        //public County County { get; set; }
        //[ForeignKey("Province")]
        //public int ProvinceId { get; set; }
        //public Province Province { get; set; }
        [Required]
        [MaxLength(50)]
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
