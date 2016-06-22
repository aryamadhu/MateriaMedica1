using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Storage;
using Windows.Storage.Streams;
using System.Threading.Tasks;
using System.IO;
using SQLiteWp8.ViewModel;
using SQLiteWp8.Views;
using System.Text.RegularExpressions;

namespace SQLiteWp8
{
    public partial class Details : PhoneApplicationPage
    {
        int Selected_RemideId = 0;
        DatabaseHelperClass Db_Helper = new DatabaseHelperClass();
        private tblRemedies currentremedie = new tblRemedies();
        
        private string value;
        private string SrchTxt;
    //    private string val;

        public Details()
        {
            InitializeComponent();
        
        }
        private string appendHTMLData(string inputstring, string tagname, string tagdata)
        {
            string finalString = "";

            finalString = String.Format("{0} {1} {2} {3} {4}", inputstring, "document.write(", "\"<h3>", tagname, "</h3>\");\n");

            finalString = String.Format("{0} {1} {2} {3} {4}", finalString, "document.write(", "\"<p>", tagdata, "</p>\");\n");
                                   
            return finalString;

        }


        private string appendHtmlDataSubhed( string inputstrng, string tagnme)
        {
            string finalstrng = "";

            finalstrng = String.Format("{0} {1} {2} {3} {4}", inputstrng, "document.write(", "\"<h2>", tagnme, "</h2>\");\n");

            // finalstrng = String.Format("{0} {1} {2} {3}", finalstrng, "document.write(", "\"<p>", tagdataa, "</p>\");\n");

            return finalstrng;
        }




        private string appendHtmlDataDesc(  string inputstrnng, string value)
          {
              string finalstrng = "";

              finalstrng = String.Format("{0} {1} {2} {3} {4}", inputstrnng, "document.write(", "\"<p>", value, "</p>\");\n");

              // finalstrng = String.Format("{0} {1} {2} {3}", finalstrng, "document.write(", "\"<p>", tagdataa, "</p>\");\n");

              return finalstrng;
          }

        

        private async Task loadhtml()
        {
           
                var rs = Application.GetResourceStream(new Uri("Message.htm", UriKind.Relative));
                StreamReader sr = new StreamReader(rs.Stream);
                string htmlText = sr.ReadToEnd();
                //   string htmlTxt = sr.ReadToEnd();
                sr.Close();




               string value = currentremedie.Subheading;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHtmlDataSubhed(htmlText, value);
                }


             value = currentremedie.Generaldesc;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHtmlDataDesc(htmlText, value);
                }


           value = currentremedie.Mind;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Mind", value);
                }



                value = currentremedie.Head;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Head", value);
                }

                value = currentremedie.Face;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Face", value);
                }

                value = currentremedie.Eyes;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Eyes", value);
                }

                value = currentremedie.Ears;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Ears", value);
                }

                value = currentremedie.Nose;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Nose", value);
                }

                value = currentremedie.Mouth;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Mouth", value);
                }


                value = currentremedie.Heart;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Heart", value);
                }

                value = currentremedie.Stomach;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Stomach", value);
                }

                value = currentremedie.Chest;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Chest", value);
                }

                value = currentremedie.Abdomen;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Abdomen", value);
                }

                value = currentremedie.Rectum;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Rectum", value);
                }

                value = currentremedie.Urinary;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Urinary", value);
                }


                value = currentremedie.Respiratory;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Respiratory", value);
                }

                value = currentremedie.Fever;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Fever", value);
                }

                value = currentremedie.Skin;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Skin", value);
                }

                value = currentremedie.Male;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Male", value);
                }

                value = currentremedie.Female;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Female", value);
                }

                value = currentremedie.Back;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Back", value);
                }


                value = currentremedie.Sleep;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Sleep", value);
                }


                value = currentremedie.Modalities;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Modalities", value);
                }


                value = currentremedie.Rcompare;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Rcompare", value);
                }


                value = currentremedie.Rantidote;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Rantidote", value);
                }


                value = currentremedie.Dose;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Dose", value);
                }


                value = currentremedie.Throat;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Throat", value);
                }


                value = currentremedie.Sexual;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Sexual", value);
                }



                value = currentremedie.Rgeneral;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Rgeneral", value);
                }



                value = currentremedie.Uses;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Uses", value);
                }


                value = currentremedie.Stool;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Stool", value);
                }


                value = currentremedie.Tissues;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Tissues", value);
                }


                value = currentremedie.Nerves;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Nerves", value);
                }


                value = currentremedie.Bones;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Bones", value);
                }


                value = currentremedie.Tongue;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Tongue", value);
                }


                value = currentremedie.Circulatory;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Circulatory", value);
                }


                value = currentremedie.Blood;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Blood", value);
                }


                value = currentremedie.Spine;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Spine", value);
                }


                value = currentremedie.Bowels;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Bowels", value);
                }



                value = currentremedie.Teeth;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Teeth", value);
                }


                value = currentremedie.Brest;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Brest", value);
                }


                value = currentremedie.Kidney;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Kidney", value);
                }


                value = currentremedie.Gastro;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Gastro", value);
                }


                value = currentremedie.Spleen;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Spleen", value);
                }


                value = currentremedie.Neck;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Neck", value);
                }


                value = currentremedie.Urine;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Urine", value);
                }


                value = currentremedie.PhysiologicDosage;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "PhysiologicDosage", value);
                }



                value = currentremedie.AlimentaryCanal;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "AlimentaryCanal", value);
                }


                value = currentremedie.Rcompatible;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Rcompatible", value);
                }



                value = currentremedie.Rinimical;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Rinimical", value);
                }


                value = currentremedie.Liver;
                if (!String.IsNullOrEmpty(value))
                {
                    htmlText = appendHTMLData(htmlText, "Liver", value);
                }



                /*     string  val = currentremedie.Subheading;
                    if (!String.IsNullOrEmpty(value))
                    {
                        htmlText = appendHTMLData(htmlText, "Subheading", value);
                    }

                   string val = currentremedie.Generaldesc;
                    if (!String.IsNullOrEmpty(val))
                    {
                        htmlText = appendHTMLName(htmlText, val);
                    }*/



                htmlText = String.Format("{0} {1} ", htmlText, "</script>\n</body>\n</html>");
               
                /////
                if (GlobalCls.SrchTxt != " ")
                {
                    htmlText = String.Format("{0} {1} ", htmlText, "</script>\n</body>\n</html>");
                    string texxt = GlobalCls.SrchTxt;


                    string pattern = texxt;
                    string replace = "<font size=3 face=Verdana color = red>" + texxt + "</font>";
                    //
                    htmlText = Regex.Replace(htmlText, pattern, replace, RegexOptions.IgnoreCase);
                    Console.WriteLine(htmlText);
                    WebView1.NavigateToString(htmlText);
                }
                else
                {
                    WebView1.NavigateToString(htmlText);
                }
           
           }

       

      

      
        private void WebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
          
            loadhtml();
               
                                
        //    WebView1.Navigate(new Uri("/FAQ.htm", UriKind.Relative));
           
        }

     

        private void WebBrowser_LoadCompleted(object sender, NavigationEventArgs e)
        {
          
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        

            Selected_RemideId = int.Parse(NavigationContext.QueryString["SelectedRemedieId"]);
            currentremedie = Db_Helper.ReadRemedie(Selected_RemideId);//Read selected remedie

           
        }





        public string SetText { get; set; }


        public string htmlText { get; set; }
    }
}







