
using System.Globalization;

using EXBP.Dipren.Data.Tests;

using Npgsql;

using NUnit.Framework;


namespace EXBP.Dipren.Data.Postgres.Tests
{
    [Explicit]
    [TestFixture]
    internal class PostgresEngineDataStoreBenchmark
    {
        protected NpgsqlDataSource DataSource { get; }


        public PostgresEngineDataStoreBenchmark()
        {
            NpgsqlDataSourceBuilder builder = new NpgsqlDataSourceBuilder(Database.ConnectionString);

            this.DataSource = builder.Build();
        }


        public void Dispose()
        {
            this.DataSource.Dispose();
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


        [Test]
        [Order(1)]
        [Repeat(1)]
        public async Task Benchmark_Tiny()
        {
            EngineDataStoreBenchmarkResult result = await this.RunBenchmarkAsync(EngineDataStoreBenchmarkSettings.Tiny);

            TestContext.WriteLine($"{result.Duration.TotalSeconds}");

            string csv = await this.FormatSnapshotsAsync(result);
        }

        [Test]
        [Order(2)]
        [Repeat(1)]
        public async Task Benchmark_Small()
        {
            EngineDataStoreBenchmarkResult result = await this.RunBenchmarkAsync(EngineDataStoreBenchmarkSettings.Small);

            TestContext.WriteLine($"{result.Duration.TotalSeconds}");

            string csv = await this.FormatSnapshotsAsync(result);
        }

        [Test]
        [Order(3)]
        [Repeat(12)]
        public async Task Benchmark_Medium()
        {
            EngineDataStoreBenchmarkResult result = await this.RunBenchmarkAsync(EngineDataStoreBenchmarkSettings.Medium);

            TestContext.WriteLine($"{result.Duration.TotalSeconds}");

            string csv = await this.FormatSnapshotsAsync(result);
        }

        [Test]
        [Order(4)]
        [Repeat(1)]
        public async Task Benchmark_Large()
        {
            EngineDataStoreBenchmarkResult result = await this.RunBenchmarkAsync(EngineDataStoreBenchmarkSettings.Large);

            TestContext.WriteLine($"{result.Duration.TotalSeconds}");

            string csv = await this.FormatSnapshotsAsync(result);
        }

        [Test]
        [Order(5)]
        [Repeat(1)]
        public async Task Benchmark_Huge()
        {
            EngineDataStoreBenchmarkResult result = await this.RunBenchmarkAsync(EngineDataStoreBenchmarkSettings.Huge);

            TestContext.WriteLine($"{result.Duration.TotalSeconds}");

            string csv = await this.FormatSnapshotsAsync(result);
        }


        private async Task<EngineDataStoreBenchmarkResult> RunBenchmarkAsync(EngineDataStoreBenchmarkSettings settings)
        {
            IEngineDataStoreFactory factory = new PostgresEngineDataStoreFactory(Database.ConnectionString);
            EngineDataStoreBenchmark benchmark = new EngineDataStoreBenchmark(factory, settings);

            EngineDataStoreBenchmarkResult result = await benchmark.RunAsync();

            Assert.That(result.Missed, Is.Zero);
            Warn.Unless(result.Errors, Is.Zero, "{0} errors were reported during processing.", result.Errors);

            return result;
        }

        private async Task<string> FormatSnapshotsAsync(EngineDataStoreBenchmarkResult source)
        {
            await using StringWriter writer = new StringWriter(CultureInfo.InvariantCulture);

            await source.SaveSnapshotsAsync(writer, true);

            string result = writer.ToString();

            return result;
        }


        private class PostgresEngineDataStoreFactory : IEngineDataStoreFactory
        {
            private readonly string _connectionString;

            public PostgresEngineDataStoreFactory(string connectionString)
            {
                this._connectionString = connectionString;
            }

            public Task<IEngineDataStore> CreateAsync(CancellationToken cancellation)
                => Task.FromResult<IEngineDataStore>(new PostgresEngineDataStore(this._connectionString));
        }
    }
}
