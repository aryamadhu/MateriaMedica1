using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SQLiteWp8.ViewModel;
using System.Collections.ObjectModel;
using SQLiteWp8;



namespace SQLiteWp8
{
    public partial class ReadNotes : PhoneApplicationPage
    {
        

       // SQLiteConnection dbConn;

        ObservableCollection<NewNotes> DB_ReadList = new ObservableCollection<NewNotes>();


        public ReadNotes()
        {
            InitializeComponent();
            this.Loaded += ReadNotes_Loaded;
        }

        

        private void ReadNotes_Loaded(object sender, RoutedEventArgs e)
        {
            ReadAllNotes dbnotes = new ReadAllNotes();
            DB_ReadList = dbnotes.GetAllNotes();//Get all DB contacts
            NotesListBx.ItemsSource = DB_ReadList.OrderByDescending(i => i.id).ToList();//Latest contact ID can Display first
        
        }

        private void NotesListBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
       
    }
}