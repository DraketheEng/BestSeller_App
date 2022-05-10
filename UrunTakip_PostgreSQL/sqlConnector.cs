using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace UrunTakip_PostgreSQL
{
    internal class sqlConnector
    {
        public NpgsqlConnection myConnection()
        {
            NpgsqlConnection connect = new NpgsqlConnection("server=localHost; port=5432; Database=ProductTracking_DB; User ID=postgres; Password=quaresma17;");
            connect.Open();
            return connect;
        }
    }
}
