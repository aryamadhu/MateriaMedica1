using SQLiteWp8;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SQLiteWp8
{
  public class ReadAllNotes
    {
        DatabaseHelperClass1 Db_Helper = new DatabaseHelperClass1();
        public ObservableCollection<NewNotes> GetAllNotes()
        {
            return Db_Helper.ReadNotes();
        }
    }
}

