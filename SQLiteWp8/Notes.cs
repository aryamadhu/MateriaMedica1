using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SQLiteWp8
{
     public class Notes : INotifyPropertyChanged
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;

        }
        public string Txt
        {
            get;
            set;

        }

     
          public Notes()
        {

        }

          public Notes(string title, string txt)
          {
              // TODO: Complete member initialization
              this.Title = title;
              this.Txt = txt;
          }


      public void NotifyPropertyChanged(String info)
          {
              if (PropertyChanged != null)
              {
                  PropertyChanged(this, new PropertyChangedEventArgs(info));
              }
          }


        public event PropertyChangedEventHandler PropertyChanged;
        
    }
}



 