
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


        [Test]
        public async Task InsertJobAsync_TimestampsAreStoredAsInstants_PreservesUtcInstant()
        {
            const string id = "DPJ-0001";
            DateTime timestamp = new DateTime(2022, 9, 21, 11, 12, 13, DateTimeKind.Utc);
            Job job = new Job(id, timestamp, timestamp, JobState.Initializing, 66, TimeSpan.FromMinutes(1), TimeSpan.Zero);
            IEngineDataStore store = await this.OnCreateEngineDataStoreAsync();

            await using IAsyncDisposable disposable = (IAsyncDisposable) store;

            await store.InsertJobAsync(job, CancellationToken.None);

            Job persisted = await store.RetrieveJobAsync(id, CancellationToken.None);

            Assert.That(persisted, Is.Not.Null);
            Assert.That(persisted.Created, Is.EqualTo(timestamp));
            Assert.That(persisted.Updated, Is.EqualTo(timestamp));
        }


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
