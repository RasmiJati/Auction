using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auction.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public string Title { get; set; }    
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public bool IsSold { get; set; }
        
        [Required]
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        
        public IdentityUser? User {  get; set; }
       
        public List<Bid>? Bids { get; set; }  //one to many relationship   i.e. 1 listing many bids
        public List<Comment>? Comments { get; set; }  //one to manay relationship
    }
}
