namespace Vacay.Models
{
   public class Cruise : Tour
   {
      public Cruise()
      {
         Type = "Cruise";
      }

      public string Ship { get; set; }
   }
}