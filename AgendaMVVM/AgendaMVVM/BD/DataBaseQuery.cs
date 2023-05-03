using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AgendaMVVM.Model;
using SQLite;

namespace AgendaMVVM.BD
{
    public class DataBaseQuery
    {

        readonly SQLiteAsyncConnection _database;


        public DataBaseQuery(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<UserModel>().Wait();
        }


        #region CRUD

        public Task<int> SaveUserModel(UserModel _usermodel )
        {
            return _database.InsertAsync(_usermodel);

        }

        public Task<List<UserModel>>GetUserModelList()
        {
            return  _database.Table<UserModel>().ToListAsync();
        }

        public Task<UserModel> GetUserModel(string usr , string pw)
        {
            return _database.Table<UserModel>().Where(x => x.User == usr && x.Pw== pw).FirstOrDefaultAsync();
        }


        #endregion




    }
}
