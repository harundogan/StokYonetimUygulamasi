using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ZaferMarketlerZinciri
{
    public class ProductDal
    {
        SqlConnection _conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=ZaferDB;Integrated Security = False");
        
        public List<Product> GetAllProducts()
        {
            SqlCommand command = new SqlCommand("select * from Products",_conn);
            ConnectionControl();
            SqlDataReader dr = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while(dr.Read())
            {
                Product product = new Product()
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Type = Convert.ToString(dr["Type"]),
                    UnitPrice = Convert.ToDecimal(dr["UnitPrice"]),
                    StockAmount = Convert.ToInt32(dr["StockAmount"])
                };
                products.Add(product);
            }
            dr.Close();
            _conn.Close();
            return products;
        }

        public void Add(Product product)
        {
            SqlCommand cmd = new SqlCommand("insert into Products Values (@Name,@Type,@UnitPrice,@StockAmount)",_conn);
            ConnectionControl();
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Type", product.Type);
            cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            cmd.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public void Update(Product product)
        {
            SqlCommand cmd = new SqlCommand("update Products set Name=@Name,Type=@Type,UnitPrice=@UnitPrice,StockAmount=@StockAmount where ID=@ID",_conn);
            ConnectionControl();
            cmd.Parameters.AddWithValue("@ID",product.ID);
            cmd.Parameters.AddWithValue("@Name",product.Name);
            cmd.Parameters.AddWithValue("@Type",product.Type);
            cmd.Parameters.AddWithValue("@UnitPrice",product.UnitPrice);
            cmd.Parameters.AddWithValue("@StockAmount",product.StockAmount);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public void Delete(Product product)
        {
            SqlCommand cmd = new SqlCommand("delete Products where ID=@ID", _conn);
            ConnectionControl();
            cmd.Parameters.AddWithValue("@ID",product.ID);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        void ConnectionControl()
        {
            if (_conn.State == ConnectionState.Closed)
                _conn.Open();
        }
    }
}
