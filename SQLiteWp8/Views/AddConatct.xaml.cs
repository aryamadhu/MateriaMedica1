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
using SQLiteWp8.Views;
using SQLite;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Sqlite;
using System.Windows.Documents;
using System.Windows.Media;
using System.Text.RegularExpressions;
using SQLiteWp8.Views;


namespace SQLiteWp8.Views
{
    public partial class AddConatct : PhoneApplicationPage
    {

        DatabaseHelperClass1 Db_Helper = new DatabaseHelperClass1();
        private tblRemedies SearchResultSet = new tblRemedies();
    

        SQLiteConnection dbConn;
        


        public AddConatct()
        {
            InitializeComponent();
        }


     

        private void ListBox_Loaded(object sender, RoutedEventArgs e)
        {
            ReadAllNames dbremedies = new ReadAllNames();
            DB_Remedies = dbremedies.GetAllNames();//Get all remedies
            List<tblRemedies> list1 = DB_Remedies.ToList(); ;

            listBoxobj1.ItemsSource = DB_Remedies.OrderBy(i => i.id).ToList();//Latest Remedie ID can Display first
        }

        private void listBoxobj_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxobj1.SelectedIndex != -1)
            {
                tblRemedies listitem = listBoxobj1.SelectedItem as tblRemedies;//Get slected listbox item id

                NavigationService.Navigate(new Uri("/Details.xaml?SelectedRemedieId=" + listitem.id, UriKind.Relative));

            }

        }



        public ObservableCollection<tblRemedies> DB_Remedies { get; set; }

        private void ListBox2_Loaded(object sender, RoutedEventArgs e)
        {


            ReadAllNames dbremedies = new ReadAllNames();
            DB_Remedies = dbremedies.GetAllNames();//Get all DB Remedies
            List<tblRemedies> list1 = DB_Remedies.ToList(); 

            listBoxobj1.ItemsSource = DB_Remedies.OrderBy(i => i.id).ToList();//Latest Remedie id can Display first

           
        }

        private void listBoxobj2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxobj2.SelectedIndex != -1)
            {
                tblRemedies listitem = listBoxobj2.SelectedItem as tblRemedies;//Get slected listbox item id

                NavigationService.Navigate(new Uri("/Details.xaml?SelectedRemedieId=" + listitem.id, UriKind.Relative));
                               
            }
        }

        private void AddNote_Click(object sender, RoutedEventArgs e)
        {
            DatabaseHelperClass1 Db_Helper = new DatabaseHelperClass1();//Creating object for DatabaseHelperClass1.cs
            if (TitleTxtBx.Text != "" & TextTxtBx.Text != "")
            {

                Db_Helper.Insert(new NewNotes(TitleTxtBx.Text, TextTxtBx.Text));//
                NavigationService.Navigate(new Uri("/ReadNotes.xaml", UriKind.Relative));//after add details redirect to Read note  page
            }
            else
            {
                MessageBox.Show("Please fill two fields");//Text should not be empty
            }
        }

        private void WebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            WebView2.Navigate(new Uri("FAQ.htm", UriKind.Relative));

        }

        private void WebBrowser_LoadCompleted(object sender, NavigationEventArgs e)
        {

        }

                      
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
        }
       
       
       public void SerchBtn_Click(object sender, RoutedEventArgs e)
        {
           
                    this.listBoxobj2.Items.Clear();
                     if (SrchTxtBx.Text != "")
                     {
                         string SrchTxt = SrchTxtBx.Text;
                         List<tblRemedies> locallist = Db_Helper.SearchText(SrchTxt);//list search remedie
                         for (int i = 0; i < locallist.Count; i++) // Loop with for.
                         {
                             this.listBoxobj2.Items.Add(locallist[i]);
                         }

                                          
                     } 
            }

       private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
       {
             this.listBoxobj2.Items.Clear();
             if (SrchTxtBx.Text != "")
             {
                 string SrchTxt = SrchTxtBx.Text;
                 List<tblRemedies> locallist2 = Db_Helper.SearchTextList(SrchTxt);//list search remedie
                 for (int i = 0; i < locallist2.Count; i++) // Loop with for.
                 {
                     this.listBoxobj2.Items.Add(locallist2[i]);
                 }
             }
       }
       
}
    
    }






      