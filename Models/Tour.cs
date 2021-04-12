namespace Vacay.Models
{
   public class Tour : Vacation
   {
      public Tour()
      {
         Type = "Tour";
      }

      public string Itinerary { get; set; }
   }
}