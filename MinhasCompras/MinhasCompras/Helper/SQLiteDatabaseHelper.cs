using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MinhasCompras.Model;
using SQLite;

namespace MinhasCompras.Helper
{
    public class SQLiteDatabaseHelper
    {

        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Produto>().Wait();
        }

        public Task<int> insert(Produto p)
        {
            return _conn.InsertAsync(p);
        }

        public void update(Produto p)
        {

        }

        public Task<Produto> getById(int id)
        {
            return new Produto();
        }

        public Task <List<Produto>> getAll()
        {
             

        }

        public void delete(int id)
        {

        }
    }
}
