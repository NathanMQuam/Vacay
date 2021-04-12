using System.Collections.Generic;
using System.Data;
using Dapper;
using Vacay.Models;

namespace Vacay.Repositories
{
   public class VacationsRepository
   {
      private readonly IDbConnection _db;

      public VacationsRepository(IDbConnection db)
      {
         _db = db;
      }

      internal IEnumerable<Vacation> GetAll()
      {
         string sql = "SELECT * FROM vacations;";
         return _db.Query<Vacation>(sql);
      }
   }
}