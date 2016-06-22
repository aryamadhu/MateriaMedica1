using SQLite;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;

using SQLiteWp8.Views;
using System.Windows.Navigation;


namespace SQLiteWp8
{
  
    //This class for perform all database CRUID operations
    public class DatabaseHelperClass1
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
                        dbConn.CreateTable<NewNotes>();
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

        public void Insert(NewNotes newnotes)
        {
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                dbConn.RunInTransaction(() =>
                {
                    dbConn.Insert(newnotes);
                });
            }
        }


        public ObservableCollection<NewNotes> ReadNotes()
        {
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                List<NewNotes> myCollection = dbConn.Table<NewNotes>().ToList<NewNotes>();
                ObservableCollection<NewNotes> ReadList = new ObservableCollection<NewNotes>(myCollection);
                return ReadList;
            }
        }
        string[] keyString = new string[] {"Generaldesc", "Mind","Head", "Face","Eyes", "Ears", 
                      "Nose","Mouth","HEART","Chest","Stomach", "Abdomen","Rectum","Urinary","Respiratory","Extremities",
                      "Skin","Male","Female","Fever","Back","Sleep","Modalities","Rcompare","Rcompliment","Rantidote","Dose","Throat","Sexual", 
                      "Rgeneral","Uses","Stool","Tissues","Nerves","Bones","Rincompatible","Tongue","Circulatory","Blood","Spine","Bowels","Teeth", 
                      "Breast","Kidney","Gastro","Spleen","Neck","Urine","PhysiologicDosage","AlimentaryCanal","Rcompatible","Rinimical","Liver"};



        public List<tblRemedies> SearchText(string SrchTxt)
        {
            GlobalCls.SrchTxt = SrchTxt;
            String sqlQuery;
            sqlQuery = "select * from tblRemedies where ";

            for (int i = 0; i < keyString.Length; i++)
            {
                string key = keyString[i];
                sqlQuery = sqlQuery + key + " like " + "'%" + SrchTxt + "%'";
                
                if (i != keyString.Length - 1)
                {
                    sqlQuery = sqlQuery + " OR ";
                }

            }
           
             using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                var Currentword = dbConn.Query<tblRemedies>(sqlQuery).FirstOrDefault();
                 List<tblRemedies> listdata = new List<tblRemedies>().ToList();
                listdata = dbConn.Query<tblRemedies>(sqlQuery);
                return listdata;
             }
           
    }


    public List<tblRemedies> SearchResultSet { get; set; }

    internal List<tblRemedies> SearchTextList(string SrchTxt)
    {
        GlobalCls.SrchTxt = SrchTxt;
        String sqlQuery;
        sqlQuery = "select * from tblRemedies where ";

        for (int i = 0; i < keyString.Length; i++)
        {
            string key = keyString[i];
            sqlQuery = sqlQuery + key + " like "+ " '% " + SrchTxt + " %' ";
            // string nme = sqlQuery;
            if (i != keyString.Length - 1)
            {
                sqlQuery = sqlQuery + " OR ";
            }

        }

        using (var dbConn = new SQLiteConnection(App.DB_PATH))
        {
            var Currentword = dbConn.Query<tblRemedies>(sqlQuery).FirstOrDefault();
            List<tblRemedies> listdata = new List<tblRemedies>().ToList();
            listdata = dbConn.Query<tblRemedies>(sqlQuery);
            return listdata;
        }
    }
    }
}


















   
  