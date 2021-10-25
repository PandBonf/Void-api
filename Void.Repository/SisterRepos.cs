using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Void.Core.Interfaces;

namespace Void.Repository
{
    public class SisterRepos : InterfaceRepos
    {

        public async Task Mmm() {
            using IDbConnection connection = new SqlConnection("Data Source =locelhost;Initial Catalog=Sisters;Integrated Security = True;");
            IEnumerable<TestClass> result = await connection.QueryAsync<TestClass>("SELECT [ID], [Name], [Age], [World], [Theme], [Color1], [Color2] FROM [Sisters].[dbo].[Turgor]"); }

           
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
        public class TestClass
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string World { get; set; }
            public string Theme { get; set; }
            public string Color1 { get; set; }
            public string Color2 { get; set; }
        }

            
    }
}
