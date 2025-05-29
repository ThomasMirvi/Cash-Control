using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Finance
{
    public static class Database
    {
        private static readonly string dbFile = "transakce.db";
        private static readonly string connectionString = $"Data Source={dbFile};Version=3;";

        // Vytvoří databázi a tabulku, pokud neexistuje
        public static void Initialize()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
            }

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                    CREATE TABLE IF NOT EXISTS Transactions (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Amount REAL NOT NULL,
                        Category TEXT NOT NULL,
                        Type TEXT CHECK(Type IN ('Příchozí', 'Odchozí')) NOT NULL,
                        Date TEXT NOT NULL
                    );";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Přidá novou transakci
        public static void AddTransaction(string name, double amount, string category, string type, DateTime date)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Transactions (Name, Amount, Category, Type, Date) VALUES (@Name, @Amount, @Category, @Type, @Date)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Date", date.ToString("dd-MM-yyyy"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Získá všechny transakce
        public static List<Transaction> GetAllTransactions()
        {
            var list = new List<Transaction>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Transactions ORDER BY Date DESC";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Transaction
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Amount = Convert.ToDouble(reader["Amount"]),
                            Category = reader["Category"].ToString(),
                            Type = reader["Type"].ToString(),
                            Date = DateTime.Parse(reader["Date"].ToString())
                        });
                    }
                }
            }

            return list;
        }
        public static Transaction GetTransactionById(int id)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Transactions WHERE Id = @id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Transaction
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Amount = Convert.ToDouble(reader["Amount"]),
                                Category = reader["Category"].ToString(),
                                Type = reader["Type"].ToString(),
                                Date = DateTime.Parse(reader["Date"].ToString())
                            };
                        }
                    }
                }
            }

            return null;
        }
        public static void UpdateTransaction(Transaction t)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Transactions 
                         SET Name = @name, Amount = @amount, Category = @category, 
                             Type = @type, Date = @date 
                         WHERE Id = @id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", t.Name);
                    cmd.Parameters.AddWithValue("@amount", t.Amount);
                    cmd.Parameters.AddWithValue("@category", t.Category);
                    cmd.Parameters.AddWithValue("@type", t.Type);
                    cmd.Parameters.AddWithValue("@date", t.Date);
                    cmd.Parameters.AddWithValue("@id", t.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteTransaction(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("DELETE FROM Transactions WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
        public static double GetBalance()
        {
            var transactions = GetAllTransactions();

            double income = transactions.Where(t => t.Type == "Income").Sum(t => t.Amount);
            double expense = transactions.Where(t => t.Type == "Expense").Sum(t => t.Amount);

            return income - expense;
        }


    }
}
