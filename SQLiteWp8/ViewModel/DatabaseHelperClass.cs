using SQLite;
using SQLiteWp8.ViewModel;
using SQLiteWp8.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteWp8.ViewModel
{
    //This class for perform all database CRUID operations
    public class DatabaseHelperClass
    {
        SQLiteConnection dbConn;
       
        //Create Tabble
        public async Task<bool> onCreate(string DB_PATH)
        {
            try
            {
                if (!CheckFileExists(DB_PATH).Result)
                {
                    using (dbConn = new SQLiteConnection(DB_PATH))
                    {
                        dbConn.CreateTable<tblRemedies>();
                    }
                } 
                return true;
            }
            catch
            {
                return false;
            }
        }
        private async Task<bool> CheckFileExists(string fileName)
        {
            try
            {
                var store = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Retrieve the specific remedie from the database.
        public tblRemedies ReadRemedie(int remedieid)
        
        {
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
               var currentremedie = dbConn.Query<tblRemedies>("select * from tblRemedies where Id ="+"'"+ remedieid +"'").FirstOrDefault();
                return currentremedie;
            }
        }
        // Retrieve the all remedie list from the database.
        public ObservableCollection<tblRemedies> ReadRemedieNames()
        {
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {


                List<tblRemedies> myCollection = dbConn.Table<tblRemedies>().ToList<tblRemedies>();
                ObservableCollection<tblRemedies> ContactsList = new ObservableCollection<tblRemedies>(myCollection);              
                return ContactsList;
            }
        }
        
   

    }
}
