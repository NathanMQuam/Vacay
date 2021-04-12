namespace Vacay.Interfaces
{
   public interface IVacation
   {
      public string Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public int Price { get; set; }
      public string Type { get; set; }
   }
}