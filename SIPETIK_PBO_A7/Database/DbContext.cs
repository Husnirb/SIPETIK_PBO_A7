using DotNetEnv;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPETIK_PBO_A7.Database
{
    public class DbContext
    {
        public string ConnStr;

        public DbContext()
        {
            Env.Load();
            ConnStr = Environment.GetEnvironmentVariable("CONN_STR");
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(ConnStr);
        }
    }
}