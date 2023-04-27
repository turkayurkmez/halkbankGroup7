namespace SingleResponsibilityFormsApp
{
    public class ProductService
    {
        public int AddProduct(string name, decimal price)
        {
            var connectionString = "Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True";
            var sqlCommandText = "INSERT into Products (ProductName, UnitPrice) values (@name,@price)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);

            var affectedResult = new DbHelper(connectionString).ExecuteNonQuery(sqlCommandText, parameters);

            return affectedResult;
        }
    }
}
