//ExecuteScalar é utilizado para consultas que retornam apenas uma linha.
using (var connection = new SqlConnection(connectionString)) 
{
  var sql = "SELECT COUNT(*) FROM Products";
  var count = connection.ExecuteScalar(sql);

  Console.WriteLine($"Total products: {count}");
}
