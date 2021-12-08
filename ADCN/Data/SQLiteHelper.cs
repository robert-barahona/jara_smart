using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ADCN.Models;
using System.IO;

namespace ADCN.Data
{
    internal class SQLiteHelper
    {
        private static SQLiteHelper instance;
        SQLiteAsyncConnection db;

        public static SQLiteHelper Instance()
        {
            if (instance == null)
            {
                instance = new SQLiteHelper();
            }
            return instance;
        }

        private SQLiteHelper()
        {
            Console.WriteLine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "results.db3"));
            db = new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "results.db3"));
            db.CreateTableAsync<Result>().Wait();
        }

        public Task<int> SaveResultAsync(Result result)
        {
            if (result.idResult == 0)
            {
                return db.InsertAsync(result);
            }
            else
            {
                return db.UpdateAsync(result);
            }
        }

        public Task<List<Result>> GetResultsAsync()
        {
            return db.Table<Result>().ToListAsync();
        }

        public Task<List<Result>> GetResultsByGame(int idGame)
        {
            return db.Table<Result>().Where(a => a.idJuego == idGame).ToListAsync();
        }
    }
}
