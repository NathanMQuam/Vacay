using System.Collections.Generic;
using System.Data;
using Dapper;
using Vacay.Models;

namespace Vacay.Repositories
{
   public class CruisesRepository
   {
      private readonly IDbConnection _db;

      public CruisesRepository(IDbConnection db)
      {
         _db = db;
      }

      internal IEnumerable<Cruise> GetAll()
      {
         string sql = @"
         SELECT * FROM vacations
         INNER JOIN cruises ON vacations.Id = cruises.Id;";
         return _db.Query<Cruise>(sql);
      }
   }
}