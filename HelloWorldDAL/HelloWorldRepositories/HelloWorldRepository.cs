using HelloWorldModel.HelloWorldModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDAL.HelloWorldRepositories
{
    public class HelloWorldRepository
    {
        HelloModel _hello = new HelloModel();

        public int Insert_HelloWorld(string hello)
        {

            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString))
            //using(var cmd = new SqlCommand("Insert_HelloWorld", conn))
            //{
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandTimeout = 3500;
            //    cmd.Parameters.AddWithValue("@Message", hello.Message);

            //    var value = cmd.ExecuteNonQuery();

            //}

            return 1;
        }

        public List<HelloModel> GetAllHelloWorld()
        {
            var returnList = new List<HelloModel>();
            returnList.Add(new HelloModel() { Id = 1, Message = "Hello World" });

            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString))
            //using (var cmd = new SqlCommand("GetAllHelloWorld", conn))
            //{
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandTimeout = 3500;

            //    using (var reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            var item = new HelloModel();

            //            item.Id = Convert.ToInt32(reader["Id"]);
            //            item.Message = reader["Message"].ToString();

            //            returnList.Add(item);

            //        }
            //    }


            //}

            return returnList;
        }

        public HelloModel GetHelloWorldById(int Id)
        {
            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString))
            //using (var cmd = new SqlCommand("GetHelloWorldById", conn))
            //{
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandTimeout = 3500;
            //    cmd.Parameters.AddWithValue("@Id", Id);
            //    using (var reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            var item = new HelloModel();

            //            item.Id = Convert.ToInt32(reader["Id"]);
            //            item.Message = reader["Message"].ToString();

            //            return item;

            //        }
            //    }


            //}

            return new HelloModel() { Id = 1, Message = "Hello World"};
        }

        public int DeleteHelloWorldById(int Id)
        {
            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString))
            //using (var cmd = new SqlCommand("DeleteHelloWorldById", conn))
            //{
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandTimeout = 3500;
            //    cmd.Parameters.AddWithValue("@Id", Id);

            //    var value = cmd.ExecuteNonQuery();

            //}

            return 1;
        }

        public int UpdateHelloWorld(HelloModel hello)
        {

            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString))
            //using (var cmd = new SqlCommand("UpdateHelloWorld", conn))
            //{
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandTimeout = 3500;
            //    cmd.Parameters.AddWithValue("@Message", hello.Message);
            //    cmd.Parameters.AddWithValue("@Id", hello.Id);

            //    var value = cmd.ExecuteNonQuery();

            //}

            return 1;
        }

    }
}
