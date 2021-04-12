using System.Collections.Generic;
using System.Data;
using Dapper;
using Vacay.Models;

namespace Vacay.Repositories
{
   public class HotelsRepository
   {
      private readonly IDbConnection _db;

      public HotelsRepository(IDbConnection db)
      {
         _db = db;
      }

      internal IEnumerable<Hotel> GetAll()
      {
         string sql = @"
         SELECT * FROM vacations
         INNER JOIN hotels ON vacations.Id = hotels.Id;";
         return _db.Query<Hotel>(sql);
      }
   }
}