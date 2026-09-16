
using EXBP.Dipren.Data.Tests;

using Npgsql;

using NUnit.Framework;


namespace EXBP.Dipren.Data.Postgres.Tests
{
    [TestFixture]
    public class PostgresEngineDataStoreTests : EngineDataStoreTests, IDisposable
    {
        protected NpgsqlDataSource DataSource { get; }


        public PostgresEngineDataStoreTests()
        {
            NpgsqlDataSourceBuilder builder = new NpgsqlDataSourceBuilder(Database.ConnectionString);

            this.DataSource = builder.Build();
        }


        public void Dispose()
        {
            this.DataSource.Dispose();
        }


        protected override Task<IEngineDataStore> OnCreateEngineDataStoreAsync()
            => Task.FromResult<IEngineDataStore>(new PostgresEngineDataStore(Database.ConnectionString));

        protected override DateTime FormatDateTime(DateTime source)
            => new DateTime(source.Ticks - (source.Ticks % (TimeSpan.TicksPerMillisecond / 1000)), source.Kind);


        [SetUp]
        public async Task BeforeEachTestCaseAsync()
        {
            await Database.DropDatabaseSchemaAsync(this.DataSource, CancellationToken.None);
            await Database.CreateDatabaseSchemaAsync(this.DataSource, CancellationToken.None);
        }

        [OneTimeTearDown]
        public async Task AfterTestFixtureAsync()
        {
            await Database.DropDatabaseSchemaAsync(this.DataSource, CancellationToken.None);
        }
    }
}
