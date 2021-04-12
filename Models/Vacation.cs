using System.ComponentModel.DataAnnotations;
using Vacay.Interfaces;

namespace Vacay.Models
{
   public class Vacation : IVacation
   {
      public string Id { get; set; }

      [Required]
      public string Name { get; set; }

      public string Description { get; set; }

      [Required]
      public int Price { get; set; }
      public string Type { get; set; }
   }
}