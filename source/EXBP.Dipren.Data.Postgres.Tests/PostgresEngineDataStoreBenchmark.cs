
using EXBP.Dipren.Data.Tests;

using Npgsql;

using NUnit.Framework;


namespace EXBP.Dipren.Data.Postgres.Tests
{
    [Explicit]
    [TestFixture]
    internal class PostgresEngineDataStoreBenchmark
    {
        private const string REPORT_DIRECTORY = "../benchmarks/";

        protected NpgsqlDataSource DataSource { get; }


        public PostgresEngineDataStoreBenchmark()
        {
            NpgsqlDataSourceBuilder builder = new NpgsqlDataSourceBuilder(Database.ConnectionString);

            this.DataSource = builder.Build();
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

            this.DataSource.Dispose();
        }


        [Test]
        [Order(1)]
        [Repeat(1)]
        public async Task Benchmark_Tiny()
        {
            EngineDataStoreBenchmarkRecording recording = await this.RunBenchmarkAsync(EngineDataStoreBenchmarkSettings.Tiny);

            await EngineDataStoreBenchmarkReport.GenerateAsync(REPORT_DIRECTORY, recording);

            TestContext.WriteLine($"{recording.Duration.TotalSeconds}");
        }

        [Test]
        [Order(2)]
        [Repeat(1)]
        public async Task Benchmark_Small()
        {
            EngineDataStoreBenchmarkRecording recording = await this.RunBenchmarkAsync(EngineDataStoreBenchmarkSettings.Small);

            await EngineDataStoreBenchmarkReport.GenerateAsync(REPORT_DIRECTORY, recording);

            TestContext.WriteLine($"{recording.Duration.TotalSeconds}");
        }

        [Test]
        [Order(3)]
        [Repeat(1)]
        public async Task Benchmark_Medium()
        {
            EngineDataStoreBenchmarkRecording recording = await this.RunBenchmarkAsync(EngineDataStoreBenchmarkSettings.Medium);

            await EngineDataStoreBenchmarkReport.GenerateAsync(REPORT_DIRECTORY, recording);

            TestContext.WriteLine($"{recording.Duration.TotalSeconds}");
        }

        [Test]
        [Order(4)]
        [Repeat(1)]
        public async Task Benchmark_Large()
        {
            EngineDataStoreBenchmarkRecording recording = await this.RunBenchmarkAsync(EngineDataStoreBenchmarkSettings.Large);

            await EngineDataStoreBenchmarkReport.GenerateAsync(REPORT_DIRECTORY, recording);

            TestContext.WriteLine($"{recording.Duration.TotalSeconds}");
        }

        [Test]
        [Order(5)]
        [Repeat(1)]
        public async Task Benchmark_Huge()
        {
            EngineDataStoreBenchmarkRecording recording = await this.RunBenchmarkAsync(EngineDataStoreBenchmarkSettings.Huge);

            await EngineDataStoreBenchmarkReport.GenerateAsync(REPORT_DIRECTORY, recording);

            TestContext.WriteLine($"{recording.Duration.TotalSeconds}");
        }


        private async Task<EngineDataStoreBenchmarkRecording> RunBenchmarkAsync(EngineDataStoreBenchmarkSettings settings)
        {
            IEngineDataStoreFactory factory = new PostgresEngineDataStoreFactory(Database.ConnectionString);
            EngineDataStoreBenchmark benchmark = new EngineDataStoreBenchmark(factory, settings);

            EngineDataStoreBenchmarkRecording result = await benchmark.RunAsync();

            Assert.That(result.Missed, Is.Zero);
            Warn.Unless(result.Errors, Is.Zero, $"{result.Errors} errors were reported during processing.");

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
