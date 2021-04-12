namespace Vacay.Models
{
   public class Hotel : Vacation
   {
      public string Location { get; set; }

      public Hotel()
      {
         Type = "Hotel";
      }
   }
}