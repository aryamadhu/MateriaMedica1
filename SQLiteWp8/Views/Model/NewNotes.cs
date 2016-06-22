using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteWp8
{
    public class NewNotes : INotifyPropertyChanged
    {

        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int id
        {
            get;
            set;
        }
        //The Id property is marked as the Primary Key
        private int idValue;
        private string TitleValue = String.Empty;
        private string TxtValue = String.Empty;
        public string Title
        {
            get { return this.TitleValue; }

            set
            {
                if (value != this.TitleValue)
                {
                    this.TitleValue = value;
                    NotifyPropertyChanged("Title");
                }
            }
        }
        public string Txt
        {
            get { return this.TxtValue; }

            set
            {
                if (value != this.TxtValue)
                {
                    this.TxtValue = value;
                    NotifyPropertyChanged("Txt");
                }
            }
        }

        /* public string CreationDate {
             get; set; 
         }*/
        public NewNotes()
        {
        }
        public NewNotes(string title, string txt)
        {
            Title = title;
            Txt = txt;
            // CreationDate = DateTime.Now.ToString();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}

