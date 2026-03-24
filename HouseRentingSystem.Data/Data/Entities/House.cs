using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HouseRentingSystem.Data.Data.DataConstants.House;


namespace HouseRentingSystem.Data.Data.Entities
{
    public class House
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(10)]
        [Required]
        public string Title { get; set; } = null!;
        [MaxLength(150)]
        [MinLength(30)]
        [Required]

        public string Address { get; set; }
        [MaxLength(500)]
        [MinLength(50)]
        [Required]

        public string Description { get; set; } = null!;
        [Required]

        public string ImageUrl { get; set; } = null!;
        [MaxLength(2000)]
        [Required]

        public string PricePerMonth { get; set; }
        public string CategoryId { get; set; }
        public Categeory Caytegory { get; set; }
        public int AgentId { get; set; }
        public Agent Agent { get; set; }
        public string? RenterId { get; set; }
        public IdentityUser? Renter { get; set; }
    }
}