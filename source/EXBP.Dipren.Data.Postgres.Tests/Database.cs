
using Npgsql;


namespace EXBP.Dipren.Data.Postgres.Tests
{
    internal static class Database
    {
        private const string PATH_SCHEMA_INSTALL_SCRIPT = @"../../../../Database/install.sql";
        private const string PATH_SCHEMA_REMOVE_SCRIPT = @"../../../../Database/remove.sql";


        internal static string ConnectionString => "Host = localhost; Port = 5432; Database = postgres; User ID = postgres; Password = development";


        internal static async Task DropDatabaseSchemaAsync(NpgsqlDataSource dataSource, CancellationToken cancellation)
        {
            string script = await File.ReadAllTextAsync(PATH_SCHEMA_REMOVE_SCRIPT, cancellation);

            await using NpgsqlCommand command = dataSource.CreateCommand(script);

            await command.ExecuteNonQueryAsync(cancellation);
        }

        internal static async Task CreateDatabaseSchemaAsync(NpgsqlDataSource dataSource, CancellationToken cancellation)
        {
            string script = await File.ReadAllTextAsync(PATH_SCHEMA_INSTALL_SCRIPT, cancellation);

            await using NpgsqlCommand command = dataSource.CreateCommand(script);

            await command.ExecuteNonQueryAsync(cancellation);
        }
    }
}
