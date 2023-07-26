using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.Library.DatabaseService
{
    public interface IBaseQuery
    {
        DataTable Execute(string query);
    }

    public class BaseQuery : IBaseQuery
    {
        SqlConnection _con;
        public BaseQuery()
        {
            _con = new SqlConnection(@"
                Data Source=172.20.1.20\DEV;
                Initial Catalog=RG_TaskWorkDB;
                User ID=sa; Password=soft157703ware;
                ");
        }
        public DataTable Execute(string query)
        {
            string cmd = query;

            var sqladapter = new SqlDataAdapter(cmd, _con);
            var commondbuilder = new SqlCommandBuilder(sqladapter);
            var result = new DataSet();
            sqladapter.Fill(result);
            _con.Close();
            _con.Dispose();
            return result.Tables[0];
        }

    }
}
