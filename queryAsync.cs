using(var con = new SqlConnection(stringConnection))
{
  var sql = "SELECT * FROM Custumers";
  var customers = con.QueryAsync(sql);
  
  foreach(var customer in customers)
  {
    Console.WriteLine($"{customer.CustomerID} {customer.CompanyName}");
  }
}

//Realizando mapeamento
public class Customer
{
    public string CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
}


using (var connection = new SqlConnection(connectionString))
{
    var sql = "SELECT * FROM Customers";
    var customers = connection.QueryAsync<Customer>(sql);
	
    foreach(var customer in customers)
    {
        Console.WriteLine($"{customer.CustomerID} {customer.CompanyName}");
    }
}
