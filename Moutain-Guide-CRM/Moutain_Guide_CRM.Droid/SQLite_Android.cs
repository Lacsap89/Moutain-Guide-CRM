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
using SQLite;
using Xamarin.Forms;
using Moutain_Guide_CRM.Droid;
using System.IO;

[assembly: Dependency(typeof(SQLite_Android))]
namespace Moutain_Guide_CRM.Droid
{
    //This class is used to create a local DB in the android device
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }

        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "Mountain_Guide_CRM_DB.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path2 = Path.Combine(documentsPath, sqliteFileName);
            //Create teh connection
            var conn = new SQLiteConnection(path2);
            //Return the database connection
            return conn;
        }
    }
}