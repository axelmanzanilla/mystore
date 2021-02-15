using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MyStore;

namespace SQLiteDb
{
    public partial class SQLiteConn
    {
        //Data base requests
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SQLiteRecordSet rs = ExecuteQuery("SELECT * FROM users"))
            {
                while (rs.NextRecord())
                {
                    users.Add(new User(rs.GetInt32("id"),
                                        rs.GetString("firstname"),
                                        rs.GetString("lastname"),
                                        rs.GetString("username"),
                                        rs.GetString("password"),
                                        rs.GetString("image")));
                }
            }
            return users;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT * FROM products"))
            {
                while (rs.NextRecord())
                {
                    products.Add(new Product(rs.GetString("id"),
                                             rs.GetString("description"),
                                             rs.GetString("category"),
                                             Convert.ToDecimal(rs.GetDouble("price")),
                                             rs.GetString("image"),
                                             Convert.ToBoolean(rs.GetInt32("active"))));
                }
            }
            return products;
        }

        public List<Product> GetAllShoppingCarts(User user)
        {
            List<Product> products = new List<Product>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT products.* FROM shoppingcarts sc INNER JOIN products " +
                                                     $"ON (products.id = sc.product_id) WHERE sc.user_id = {user.id}"))
            {
                while (rs.NextRecord())
                {
                    products.Add(new Product(rs.GetString("id"),
                                             rs.GetString("description"),
                                             rs.GetString("category"),
                                             Convert.ToDecimal(rs.GetDouble("price")),
                                             rs.GetString("image"),
                                             Convert.ToBoolean(rs.GetInt32("active"))));
                }
            }
            return products;
        }

        public int GetQuantityOfProduct(User user, Product product)
        {
            int quantity = 0;
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT quantity FROM shoppingcarts WHERE " +
                                                     $"user_id = {user.id} AND product_id= '{product.id}'"))
            {
                while (rs.NextRecord())
                {
                    quantity = rs.GetInt32("quantity");
                }
            }
            return quantity;
        }

        public List<Product> GetAllCart(int user_id)
        {
            List<Product> products = new List<Product>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT products.* FROM shoppingcarts sc INNER JOIN products " +
                                                     $"ON (products.id = sc.product_id) WHERE user_id = {user_id}"))
            {
                while (rs.NextRecord())
                {
                    products.Add(new Product(rs.GetString("id"),
                                             rs.GetString("description"),
                                             rs.GetString("category"),
                                             Convert.ToDecimal(rs.GetDouble("price")),
                                             rs.GetString("image"),
                                             Convert.ToBoolean(rs.GetInt32("active"))));
                }
            }
            return products;
        }

        public User GetUserLogged()
        {
            User user = null;
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT id, firstname, lastname, username, " +
                "password, image FROM user_logged ul INNER JOIN users u ON ul.user_id = u.id"))
            {
                while (rs.NextRecord())
                {
                    user = new User(rs.GetInt32("id"),
                                    rs.GetString("firstname"),
                                    rs.GetString("lastname"),
                                    rs.GetString("username"),
                                    rs.GetString("password"),
                                    rs.GetString("image"));
                }
            }
            return user;
        }

        public int GetMaxId()
        {
            int id = 0;
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT id FROM users ORDER BY id DESC LIMIT 1"))
            {
                while (rs.NextRecord())
                {
                    id = rs.GetInt32("id");
                }
            }
            return id;
        }

        public List<string> GetCategories()
        {
            List<string> categories = new List<string>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT category FROM products GROUP BY category"))
            {
                while (rs.NextRecord())
                {
                    categories.Add(rs.GetString("category"));
                }
            }
            return categories;
        }

        public List<Product> GetProductsWithFilter(string description, string category, string min, string max, bool active)
        {
            List<Product> products = new List<Product>();
            string query = $"SELECT * FROM products WHERE description LIKE '{description}%' AND price >= {min} AND price <= {max}";
            if (category != "Todas") query += $" AND category = '{category}';";
            if (active) query += $" AND active = 1";

            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    products.Add(new Product(rs.GetString("id"),
                                             rs.GetString("description"),
                                             rs.GetString("category"),
                                             Convert.ToDecimal(rs.GetDouble("price")),
                                             rs.GetString("image"),
                                             Convert.ToBoolean(rs.GetInt32("active"))));
                }
            }
            return products;
        }

        public List<Product> GetProductsMaxFilter(string text)
        {
            List<Product> products = new List<Product>();
            string query = $"SELECT * FROM products WHERE id LIKE '{text}%' OR description LIKE '{text}%' " +
                           $"OR price = '{text}' OR category = '{text}';";

            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    products.Add(new Product(rs.GetString("id"),
                                             rs.GetString("description"),
                                             rs.GetString("category"),
                                             Convert.ToDecimal(rs.GetDouble("price")),
                                             rs.GetString("image"),
                                             Convert.ToBoolean(rs.GetInt32("active"))));
                }
            }
            return products;
        }
    }
}
