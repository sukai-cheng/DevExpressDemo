using SqlSugar;

namespace DevExpressDemo.Common
{
    public class DatabaseContext : IDisposable
    {
        private SqlSugarClient? _db;
        private readonly DatabaseType _dbType;
        private readonly string _connectionString;

        // 数据源类型枚举
        public enum DatabaseType
        {
            SqlServer,
            PostgreSQL
        }

        // 默认构造函数 - 使用SqlServer
        public DatabaseContext()
        {
            _dbType = DatabaseType.SqlServer;
            _connectionString = "Server=10.6.61.36;Database=pts;User ID=gx-mes;Password=mes20251015!;TrustServerCertificate=True";
        }

        // 带参数的构造函数 - 指定数据源类型和连接字符串
        public DatabaseContext(DatabaseType dbType, string connectionString)
        {
            _dbType = dbType;
            _connectionString = connectionString;
        }

        // 便捷构造函数 - 只指定数据源类型，使用默认连接字符串
        public DatabaseContext(DatabaseType dbType)
        {
            _dbType = dbType;
            _connectionString = GetDefaultConnectionString(dbType);
        }

        public SqlSugarClient DB
        {
            get
            {
                if (_db == null)
                {
                    DbType dbType;
                    switch (_dbType)
                    {
                        case DatabaseType.SqlServer:
                            dbType = DbType.SqlServer;
                            break;
                        case DatabaseType.PostgreSQL:
                            dbType = DbType.PostgreSQL;
                            break;
                        default:
                            dbType = DbType.SqlServer;
                            break;
                    }

                    _db = new SqlSugarClient(new ConnectionConfig()
                    {
                        ConnectionString = _connectionString,
                        DbType = dbType,
                        IsAutoCloseConnection = true
                    });

                    _db.Aop.OnLogExecuting = (sql, pars) => {
                        Console.WriteLine($"【{_dbType}】SQL: {sql}");
                        if (pars != null)
                        {
                            Console.WriteLine($"参数: {string.Join(", ", pars.Select(p => $"{p.ParameterName}: {p.Value}"))}");
                        }
                        Console.WriteLine("--------------------------------------------------");
                    };
                }
                return _db;
            }
        }

        // 获取默认连接字符串
        private string GetDefaultConnectionString(DatabaseType dbType)
        {
            switch (dbType)
            {
                case DatabaseType.SqlServer:
                    return "Server=10.6.61.36;Database=pts;User ID=gx-mes;Password=mes20251015!;TrustServerCertificate=True";
                case DatabaseType.PostgreSQL:
                    return "Host=10.6.61.116;Port=5432;Database=color_coating_system;Username=postgres;Password=ht@666";
                default:
                    return "Server=10.6.61.36;Database=pts;User ID=gx-mes;Password=mes20251015!;TrustServerCertificate=True";
            }
        }

        // 静态方法创建不同数据源的实例
        public static DatabaseContext CreateSqlServerContext(string? connectionString = null)
        {
            return string.IsNullOrEmpty(connectionString)
                ? new DatabaseContext(DatabaseType.SqlServer)
                : new DatabaseContext(DatabaseType.SqlServer, connectionString);
        }

        public static DatabaseContext CreatePostgreSQLContext(string? connectionString = null)
        {
            return string.IsNullOrEmpty(connectionString)
                ? new DatabaseContext(DatabaseType.PostgreSQL)
                : new DatabaseContext(DatabaseType.PostgreSQL, connectionString);
        }

        // 获取当前数据源类型
        public DatabaseType CurrentDatabaseType => _dbType;

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }
    }
}
