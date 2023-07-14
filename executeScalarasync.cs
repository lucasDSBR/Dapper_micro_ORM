//Dapper ExecuteScalarAsync 
using(var connection = new SqlConnection(connectionString))
{
  var sql = "SELECT COUNT(*) FROM Products";
  var count = await connection.ExecuteScalarAsync(sql);

  Console.writeLine($"Total products: {count}");
}

//Informando um parametro generico
using(var connection = new SqlConnection(connectionString))
{
  var sql = "SELECT COUNT(*) FROM Products";
  var count = await connection.ExecuteScalarAsync<int>(sql);

  Console.writeLine($"Total products: {count}");
}
