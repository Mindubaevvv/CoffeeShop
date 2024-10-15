using Microsoft.AspNetCore.Mvc;
using TestDelete.Models;

namespace TestDelete.Controllers
{
    public class ContactController : Controller
    {
        //string connectionString = "Server=localhost;Port=5432;Database=contact;User Id=postgres;Password=Inmin2004;";
        //private readonly object? dataGridView1;

        public IActionResult Index()
        {
            return View();
            /*SqlConnectionReader();*/
        }

        //[HttpPost]
        //public IActionResult Send(Contact contact)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return Redirect("Index");
        //    }
        //    return View("Index");
        //}

        //private void SqlConnectionReader()
        //{
        //    NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString);

        //    sqlConnection.Open();

        //    NpgsqlCommand command = new NpgsqlCommand();
        //    command.Connection = sqlConnection;
        //    command.CommandType = CommandType.Text;
        //    command.CommandText = "SELECT * FROM clients";
        //    NpgsqlDataReader dataReader = command.ExecuteReader();
        //    if (dataReader.HasRows)
        //    {
        //        DataTable data = new DataTable();
        //        data.Load(dataReader);
        //        dataGridView1.DataSource = data;
        //    }


        //    command.Dispose();

        //    sqlConnection.Close();
        //}
    }
}
