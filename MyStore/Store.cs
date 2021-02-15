using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteDb;

namespace MyStore
{
    public class Product
    {
        public string id { get; }
        public string description { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }
        public string image { get; set; }
        public bool active { get; set; }

        private Product(string id)
        {
            this.id = id;
        }

        public Product(string id, string description, string category, decimal price, string image, bool active) : this(id)
        {
            this.description = description;
            this.category = category;
            this.price = price;
            this.image = image;
            this.active = active;
        }
    }

    public class User
    {
        public int id { get; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string image { get; set; }

        public User(int id, string firstname, string lastname, string username, string password, string image)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
            this.username = username;
            this.image = image;
        }
    }

    public class Catalog
    {
        private List<Product> products;
        public int count { get => products.Count(); }
        private SQLiteConn db;

        public Catalog(string filename)
        {
            db = new SQLiteConn(filename, true);
            products = db.GetAllProducts();
        }

        public Product FindProduct(string id)
        {
            return products.Find(p => p.id == id);
        }

        public List<Product> FindProducts(string description, List<Product> products)
        {
            return products.FindAll(p => p.description.ToUpper().Contains(description.ToUpper()));
        }

        public List<Product> FindProducts(decimal min, decimal max, bool active = true)
        {
            if(active) return GetActiveProducts().FindAll(p => (p.price >= min) && (p.price <= max));
            else return products.FindAll(p => (p.price >= min) && (p.price <= max));
        }

        public List<Product> FindProductsWithFilter(string description, string category, string min, string max, bool checkbox)
        {
            string imin = "0";
            string imax = "99999999";

            if (min.Length > 0) imin = min;
            if (max.Length > 0) imax = max;

            return db.GetProductsWithFilter(description, category, imin, imax, checkbox);
        }

        public List<Product> FindProductsWithMaxFilter(string text)
        {
            return db.GetProductsMaxFilter(text);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public List<Product> GetActiveProducts()
        {
            List<Product> products = new List<Product>();
            this.products.FindAll(p => p.active == true).ForEach(p => products.Add(p));
            return products;
        }

        public List<string> GetCategories()
        {
            return db.GetCategories();
        }

        public void AddProduct(Product product)
        {
            db.ExecuteNonQuery($"INSERT INTO products (id, description, category, price, image, active) VALUES ('{product.id}', " +
                $"'{product.description}', '{product.category}', {product.price}, '{product.image}', {Convert.ToInt32(product.active)});");
        }

        public void RemoveProduct(Product product)
        {
            db.ExecuteNonQuery($"DELETE FROM products WHERE id = '{product.id}'");
        }

        public void UpdateProduct(Product product)
        {
            db.ExecuteNonQuery($"UPDATE products SET description = '{product.description}', category = '{product.category}', " +
                $"price = {product.price}, active = {product.active} WHERE id = '{product.id}';");
        }
    }

    public class ShoppingCart
    {
        private SQLiteConn db;
        public int count { get => db.GetAllShoppingCarts(db.GetUserLogged()).Count(); }

        public ShoppingCart(string filename)
        {
            db = new SQLiteConn(filename, true);
        }

        public void AddProduct(Product product, int quantity = 1)
        {
            if(!GetCart().Exists(p => p.id == product.id))
            {
                db.ExecuteNonQuery($"INSERT INTO shoppingcarts (user_id, product_id, quantity) " +
                                   $"VALUES ({db.GetUserLogged().id}, '{product.id}', {quantity})");
            }
            else
            {
                int q = db.GetQuantityOfProduct(db.GetUserLogged(), product) + quantity;
                db.ExecuteNonQuery($"UPDATE shoppingcarts SET quantity = {q} WHERE " +
                               $"user_id = {db.GetUserLogged().id} AND product_id = '{product.id}';");
            }
        }

        public void RemoveFirstProduct(Product product)
        {
            int q = db.GetQuantityOfProduct(db.GetUserLogged(), product) - 1;
            db.ExecuteNonQuery($"UPDATE shoppingcarts SET quantity = {q} WHERE " +
                               $"user_id = {db.GetUserLogged().id} AND product_id = '{product.id}';");
        }

        public void RemoveAllProducts(Product product)
        {
            db.ExecuteNonQuery($"DELETE FROM shoppingcarts WHERE user_id = {db.GetUserLogged().id} AND product_id = {product.id}");
        }

        public void Clear()
        {
            db.ExecuteNonQuery($"DELETE FROM shoppingcarts WHERE user_id = {db.GetUserLogged().id}");
        }

        public decimal CalculateTotalCost()
        {
            decimal total = 0;
            db.GetAllShoppingCarts(db.GetUserLogged()).ForEach(p => total += (p.price * GetQuantity(p)));
            return total;
        }

        public List<Product> GetCart()
        {
            return db.GetAllShoppingCarts(db.GetUserLogged());
        }

        public int GetQuantity(Product product)
        {
            return db.GetQuantityOfProduct(db.GetUserLogged(), product);
        }

    }

    public class Users
    {
        private List<User> usuarios;
        SQLiteConn db;

        public Users(string filename)
        {
            db = new SQLiteConn(filename, true);
            usuarios = db.GetAllUsers();
        }

        public void CreateUser(string firstname, string lastname, string username, string password)
        {
            User u = new User(db.GetMaxId() + 1, firstname, lastname, username, password, "default.png");
            db.ExecuteNonQuery("INSERT INTO users (id, firstname, lastname, username, password, image) VALUES " +
                    $"({u.id}, '{u.firstname}', '{u.lastname}', '{u.username}', '{u.password}', '{u.image}')");
        }

        public void UpdateUser(string firstname, string lastname, string username, string password, string image)
        {
            if (image == null) image = "default.png";
            db.ExecuteNonQuery($"UPDATE users SET firstname = '{firstname}', lastname = '{lastname}', " +
                    $"username = '{username}', password = '{password}', image = '{image}' WHERE users.id = {GetUserLogged().id}");
        }
        public User GetUserLogged()
        {
            return db.GetUserLogged();
        }

        public void DeleteUserLogged()
        {
            db.ExecuteNonQuery("DELETE FROM user_logged");
        }

        public void InsertUserLogged(string username)
        {
            db.ExecuteNonQuery($"INSERT INTO user_logged (user_id) VALUES ({db.GetAllUsers().Find(u => u.username == username).id})");
        }

        public bool UserExists(string username)
        {
            return usuarios.Exists(u => u.username == username);
        }

        public bool isThePassword(string username, string password)
        {
            return (usuarios.Find(u => u.username == username).password == password);
        }
    }
}