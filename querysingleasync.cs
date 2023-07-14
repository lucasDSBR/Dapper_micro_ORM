using (var connection = new SqlConnection(connectionString))
{
    var sql = "SELECT * FROM Customers WHERE CustomerID = 1";
    var customer = await connection.QuerySingleAsync(sql);
    
    Console.WriteLine($"{customer.CustomerID} {customer.CompanyName}");
}

using (var connection = new SqlConnection(connectionString))
{
    var sql = "SELECT * FROM Customers WHERE CustomerID = 1";
    var customer = await connection.QuerySingleAsync<Customer>(sql);
    
    Console.WriteLine($"{customer.CustomerID} {customer.CompanyName}");
}
