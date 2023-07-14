//Utilizado apenas quando queremos retornar uma linha do banco
using(var connection = new SqlConnection(connectionString))
{
  var sql = "SELECT * FROM Products WHERE ProductID = 1";
  var product = connection.QuerySingle(sql);

  Console.lWriteLine($"{product.productID} {product.ProductName}");
}

//Montando objeto
public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public int? SupplierId { get; set; }
    public int? CategoryId { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }
    public short? UnitsOnOrder { get; set; }
    public short? ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
    public DateTime? DiscontinuedDate { get; set; }
    public Category Category { get; set; }
    public Supplier Supplier { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; } = new HashSet<OrderDetail>();
}

using (var connection = new SqlConnection(connectionString))
{
    var sql = "SELECT * FROM Products WHERE ProductID = 1";
    var product = connection.QuerySingle<Product>(sql);
	
    Console.WriteLine($"{product.ProductID} {product.ProductName}");
}
