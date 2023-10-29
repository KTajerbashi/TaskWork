using BusinessLogic.Library;
using System.Data;
using System.Data.SqlClient;

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

            //_con = new SqlConnection(@"
            //    Data Source=TAJERBASHI;
            //    Initial Catalog=RG_TaskWorkDB;
            //    User ID=sa;
            //    Password=123123;
            //    ");
        }
        public DataTable Execute(string query)
        {
            string cmd = query;

            var sqladapter = new SqlDataAdapter(cmd, _con);
            var commondbuilder = new SqlCommandBuilder(sqladapter);
            var result = new DataSet();
            sqladapter.Fill(result);
            //_con.Close();
            //_con.Dispose();
            return result.Tables[0];
        }

    }
}
