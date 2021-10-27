using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Void.Core.Interfaces;
using Void.Core.Models;

namespace Void.Repository
{
    public class SisterRepos : InterfaceRepos
    {

        public async Task<IEnumerable<SisterModel>> Get() {
            using IDbConnection connection = new SqlConnection("Data Source =locelhost;Initial Catalog=Sisters;Integrated Security = True;");
            IEnumerable<SisterModel> result = await connection.QueryAsync<SisterModel>("SELECT [ID], [Name], [Age], [World], [Theme], [Color1], [Color2] FROM [Sisters].[dbo].[Turgor]");
            return result;
        }

           
        public async Task Insert()
        {
            using IDbConnection connection = new SqlConnection("Data Source =localhost;Initial Catalog=Sisters;Integrated Security = True;");

            await connection.ExecuteAsync("INSERT INTO dbo.Sisters (ID, Name, Age, World, Theme, Color1, Color2) VALUES (@ID, @Name, @Age, @World, @Theme, @Color1, @Color2)",
                new { ID = 29, Name = "", Age = 29, World = "", Theme ="", Color1 = "", Color2 = "" });
        }

        public async Task Update()
        {
            using IDbConnection connection = new SqlConnection("Data Source =localhost;Initial Catalog=Sisters;Integrated Security = True;");

            await connection.ExecuteAsync("UPDATE dbo.Sisters SET Name = 'LULZ' WHERE Name = 'Ута'");
        }
        

            
    }
}
