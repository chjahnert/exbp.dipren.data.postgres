### Postgres Engine Data Store for Dipren

This package contains a Postgres Engine Data Store for **DIPREN**. This implementation is suitable for processing clusters with hundreds or thousands of processing nodes.

The SQL script for installing the required database objects is copied to the `EXBP.Dipren` directory inside the output directory of the referencing project during build. The script creates the `dipren` schema which contains all object required by this component. Use your favorite database management tool to run the script.

Pass the connection string to the constructor of the `PostgresEngineDataStore` type when the distributed processing job is defined.