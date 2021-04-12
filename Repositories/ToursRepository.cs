using System.Collections.Generic;
using System.Data;
using Dapper;
using Vacay.Models;

namespace Vacay.Repositories
{
   public class ToursRepository
   {
      private readonly IDbConnection _db;

      public ToursRepository(IDbConnection db)
      {
         _db = db;
      }

      internal IEnumerable<Tour> GetAll()
      {
         string sql = @"
         SELECT * FROM vacations
         INNER JOIN tours ON vacations.Id = tours.Id;";
         return _db.Query<Tour>(sql);
      }
   }
}