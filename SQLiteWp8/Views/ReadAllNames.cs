using SQLiteWp8.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SQLiteWp8.Views
{
    class ReadAllNames
    {
        DatabaseHelperClass Db_Helper = new DatabaseHelperClass();
        public ObservableCollection<tblRemedies> GetAllNames()
        {
            return Db_Helper.ReadRemedieNames();
        }

      
    }
}
