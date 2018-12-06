using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using SQLite;
using PracticalCodingTest.Model;

namespace PracticalCodingTest
{
    public class DbService
    {
        SQLiteConnection db;
        public DbService()
        {
            // Creating Database
            Console.WriteLine("Creating database, if it doesn't already exist");
            string dbPath = Path.Combine(
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
                 "User.db3");
            // Connection to DB
             db = new SQLiteConnection(dbPath);
            db.CreateTable<User>();
        }

        public void AddUser(User user)
        {
            // Adding user 
            db.Insert(user);

        }

        public List<User> getUsers()
        {
            
            //Getting users

            var table = db.Table<User>();
            return table.ToList<User>();
        }
    }

}