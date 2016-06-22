using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SQLiteWp8.Views
{
    public class tblRemedies : INotifyPropertyChanged
    {

        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int id
        {
            get;
            set;
        }
        //The Id property is marked as the Primary Key
        private int idValue;
        private string NameValue = String.Empty;
       
        public string Name
        {
            get { return this.NameValue; }

            set
            {
                if (value != this.NameValue)
                {
                    this.NameValue = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }


       public string Subheading
        {
            get { return this.SubheadingValue; }

            set
            {
                if (value != this.SubheadingValue)
                {
                    this.SubheadingValue = value;
                    NotifyPropertyChanged("Subheading");
                }
            }
        }


       public string Generaldesc
       {
           get { return this.GeneraldescValue; }

           set
           {
               if (value != this.GeneraldescValue)
               {
                   this.GeneraldescValue = value;
                   NotifyPropertyChanged("Generaldesc");
               }
           }
       }



       public string Mind
       {
           get { return this.MindValue; }

           set
           {
               if (value != this.MindValue)
               {
                   this.MindValue = value;
                   NotifyPropertyChanged("Mind");
               }
           }
       }




       public string Head
       {
           get { return this.HeadValue; }

           set
           {
               if (value != this.HeadValue)
               {
                   this.HeadValue = value;
                   NotifyPropertyChanged("Head");
               }
           }
       }



       public string Face
       {
           get { return this.FaceValue; }

           set
           {
               if (value != this.FaceValue)
               {
                   this.FaceValue = value;
                   NotifyPropertyChanged("Face");
               }
           }
       }


       public string Eyes
       {
           get { return this.EyesValue; }

           set
           {
               if (value != this.EyesValue)
               {
                   this.EyesValue = value;
                   NotifyPropertyChanged("Eyes");
               }
           }
       }


       public string Ears
       {
           get { return this.EarsValue; }

           set
           {
               if (value != this.EarsValue)
               {
                   this.EarsValue = value;
                   NotifyPropertyChanged("Ears");
               }
           }
       }



       public string Nose
       {
           get { return this.NoseValue; }

           set
           {
               if (value != this.NoseValue)
               {
                   this.NoseValue = value;
                   NotifyPropertyChanged("Nose");
               }
           }
       }


       public string Mouth
       {
           get { return this.MouthValue; }

           set
           {
               if (value != this.MouthValue)
               {
                   this.MouthValue = value;
                   NotifyPropertyChanged("Mouth");
               }
           }
       }


       public string Heart
       {
           get { return this.HeartValue; }

           set
           {
               if (value != this.HeartValue)
               {
                   this.HeartValue = value;
                   NotifyPropertyChanged("Heart");
               }
           }
       }



       public string Chest
       {
           get { return this.ChestValue; }

           set
           {
               if (value != this.ChestValue)
               {
                   this.ChestValue = value;
                   NotifyPropertyChanged("Chest");
               }
           }
       }


       public string Stomach
       {
           get { return this.StomachValue; }

           set
           {
               if (value != this.StomachValue)
               {
                   this.StomachValue = value;
                   NotifyPropertyChanged("Stomach");
               }
           }
       }


       public string Abdomen
       {
           get { return this.AbdomenValue; }

           set
           {
               if (value != this.AbdomenValue)
               {
                   this.AbdomenValue = value;
                   NotifyPropertyChanged("Abdomen");
               }
           }
       }


       public string Rectum
       {
           get { return this.RectumValue; }

           set
           {
               if (value != this.RectumValue)
               {
                   this.RectumValue = value;
                   NotifyPropertyChanged("Rectum");
               }
           }
       }


       public string Urinary
       {
           get { return this.UrinaryValue; }

           set
           {
               if (value != this.UrinaryValue)
               {
                   this.UrinaryValue = value;
                   NotifyPropertyChanged("Urinary");
               }
           }
       }


       public string Respiratory
       {
           get { return this.RespiratoryValue; }

           set
           {
               if (value != this.RespiratoryValue)
               {
                   this.RespiratoryValue = value;
                   NotifyPropertyChanged("Respiratory");
               }
           }
       }


       public string Fever
       {
           get { return this.FeverValue; }

           set
           {
               if (value != this.FeverValue)
               {
                   this.FeverValue = value;
                   NotifyPropertyChanged("Fever");
               }
           }
       }


     /*  public string Extremities
       {
           get { return this.ExtremitiesValue; }

           set
           {
               if (value != this.Extremities)
               {
                   this.Extremities = value;
                   NotifyPropertyChanged("Extremities");
               }
           }
       }*/


       public string Skin
       {
           get { return this.SkinValue; }

           set
           {
               if (value != this.SkinValue)
               {
                   this.SkinValue = value;
                   NotifyPropertyChanged("Skin");
               }
           }
       }


       public string Male
       {
           get { return this.MaleValue; }

           set
           {
               if (value != this.MaleValue)
               {
                   this.MaleValue = value;
                   NotifyPropertyChanged("Male");
               }
           }
       }


       public string Female
       {
           get { return this.FemaleValue; }

           set
           {
               if (value != this.FemaleValue)
               {
                   this.FemaleValue = value;
                   NotifyPropertyChanged("Female");
               }
           }
       }


       public string Back
       {
           get { return this.BackValue; }

           set
           {
               if (value != this.BackValue)
               {
                   this.BackValue = value;
                   NotifyPropertyChanged("Back");
               }
           }
       }



       public string Sleep
       {
           get { return this.SleepValue; }

           set
           {
               if (value != this.SleepValue)
               {
                   this.SleepValue = value;
                   NotifyPropertyChanged("Sleep");
               }
           }
       }

       public string Modalities
       {
           get { return this.ModalitiesValue; }

           set
           {
               if (value != this.ModalitiesValue)
               {
                   this.ModalitiesValue = value;
                   NotifyPropertyChanged("Modalities");
               }
           }
       }


       public string Rcompare
       {
           get { return this.RcompareValue; }

           set
           {
               if (value != this.RcompareValue)
               {
                   this.RcompareValue = value;
                   NotifyPropertyChanged("Rcompare");
               }
           }
       }


       public string Rantidote
       {
           get { return this.RantidoteValue; }

           set
           {
               if (value != this.RantidoteValue)
               {
                   this.RantidoteValue = value;
                   NotifyPropertyChanged("Rantidote");
               }
           }
       }


       public string Dose
       {
           get { return this.DoseValue; }

           set
           {
               if (value != this.DoseValue)
               {
                   this.DoseValue = value;
                   NotifyPropertyChanged("Dose");
               }
           }
       }


       public string Throat
       {
           get { return this.ThroatValue; }

           set
           {
               if (value != this.ThroatValue)
               {
                   this.ThroatValue = value;
                   NotifyPropertyChanged("Throat");
               }
           }
       }


       public string Sexual 
       {
           get { return this.SexualValue; }

           set
           {
               if (value != this.SexualValue)
               {
                   this.SexualValue = value;
                   NotifyPropertyChanged("Sexual");
               }
           }
       }


       public string Rgeneral
       {
           get { return this.RgeneralValue; }

           set
           {
               if (value != this.RgeneralValue)
               {
                   this.RgeneralValue = value;
                   NotifyPropertyChanged("Rgeneral");
               }
           }
       }



       public string Uses
       {
           get { return this.UsesValue; }

           set
           {
               if (value != this.UsesValue)
               {
                   this.UsesValue = value;
                   NotifyPropertyChanged("Uses");
               }
           }
       }


       public string Stool
       {
           get { return this.StoolValue; }

           set
           {
               if (value != this.StoolValue)
               {
                   this.StoolValue = value;
                   NotifyPropertyChanged("Stool");
               }
           }
       }



       public string Tissues
       {
           get { return this.TissuesValue; }

           set
           {
               if (value != this.TissuesValue)
               {
                   this.TissuesValue = value;
                   NotifyPropertyChanged("Tissues");
               }
           }
       }



       public string Nerves
       {
           get { return this.NervesValue; }

           set
           {
               if (value != this.NervesValue)
               {
                   this.NervesValue = value;
                   NotifyPropertyChanged("Nerves");
               }
           }
       }

        

       public string Bones
       {
           get { return this.BonesValue; }

           set
           {
               if (value != this.BonesValue)
               {
                   this.BonesValue = value;
                   NotifyPropertyChanged("Bones");
               }
           }
       }



       public string Tongue
       {
           get { return this.TongueValue; }

           set
           {
               if (value != this.TongueValue)
               {
                   this.TongueValue = value;
                   NotifyPropertyChanged("Tongue");
               }
           }
       }



       public string Circulatory
       {
           get { return this.CirculatoryValue; }

           set
           {
               if (value != this.CirculatoryValue)
               {
                   this.CirculatoryValue = value;
                   NotifyPropertyChanged("Circulatory");
               }
           }
       }



       public string Blood
       {
           get { return this.BloodValue; }

           set
           {
               if (value != this.BloodValue)
               {
                   this.BloodValue = value;
                   NotifyPropertyChanged("Blood");
               }
           }
       }



       public string Spine
       {
           get { return this.SpineValue; }

           set
           {
               if (value != this.SpineValue)
               {
                   this.SpineValue = value;
                   NotifyPropertyChanged("Spine");
               }
           }
       }



       public string Bowels
       {
           get { return this.BowelsValue; }

           set
           {
               if (value != this.BowelsValue)
               {
                   this.BowelsValue = value;
                   NotifyPropertyChanged("Bowels");
               }
           }
       }




       public string Teeth
       {
           get { return this.TeethValue; }

           set
           {
               if (value != this.TeethValue)
               {
                   this.TeethValue = value;
                   NotifyPropertyChanged("Teeth");
               }
           }
       }



       public string Brest
       {
           get { return this.BrestValue; }

           set
           {
               if (value != this.BrestValue)
               {
                   this.BrestValue = value;
                   NotifyPropertyChanged("Brest");
               }
           }
       }




       public string Kidney
       {
           get { return this.KidneyValue; }

           set
           {
               if (value != this.KidneyValue)
               {
                   this.KidneyValue = value;
                   NotifyPropertyChanged("Kidney");
               }
           }
       }




       public string Gastro
       {
           get { return this.GastroValue; }

           set
           {
               if (value != this.GastroValue)
               {
                   this.GastroValue = value;
                   NotifyPropertyChanged("Gastro");
               }
           }
       }




       public string Spleen
       {
           get { return this.SpleenValue; }

           set
           {
               if (value != this.SpleenValue)
               {
                   this.SpleenValue = value;
                   NotifyPropertyChanged("Spleen");
               }
           }
       }




       public string Neck
       {
           get { return this.NeckValue; }

           set
           {
               if (value != this.NeckValue)
               {
                   this.NeckValue = value;
                   NotifyPropertyChanged("Neck");
               }
           }
       }




       public string Urine
       {
           get { return this.UrineValue; }

           set
           {
               if (value != this.UrineValue)
               {
                   this.UrineValue = value;
                   NotifyPropertyChanged("Urine");
               }
           }
       }




       public string PhysiologicDosage
       {
           get { return this.PhysiologicDosageValue; }

           set
           {
               if (value != this.PhysiologicDosageValue)
               {
                   this.PhysiologicDosageValue = value;
                   NotifyPropertyChanged("PhysiologicDosage");
               }
           }
       }




       public string AlimentaryCanal
       {
           get { return this.AlimentaryCanalValue; }

           set
           {
               if (value != this.AlimentaryCanalValue)
               {
                   this.AlimentaryCanalValue = value;
                   NotifyPropertyChanged("AlimentaryCanal");
               }
           }
       }




       public string Rcompatible
       {
           get { return this.RcompatibleValue; }

           set
           {
               if (value != this.RcompatibleValue)
               {
                   this.RcompatibleValue = value;
                   NotifyPropertyChanged("Rcompatible");
               }
           }
       }




       public string Rinimical
       {
           get { return this.RinimicalValue; }

           set
           {
               if (value != this.RinimicalValue)
               {
                   this.RinimicalValue = value;
                   NotifyPropertyChanged("Rinimical");
               }
           }
       }

        


       public string Liver
       {
           get { return this.LiverValue; }

           set
           {
               if (value != this.LiverValue)
               {
                   this.LiverValue = value;
                   NotifyPropertyChanged("Liver");
               }
           }
       }



                

       public tblRemedies()
           {
              
              
           }

      
        public event PropertyChangedEventHandler PropertyChanged;
        private string HeadValue;
       

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }



        public string SubheadingValue { get; set; }

        public string GeneraldescValue { get; set; }

        public string MindValue { get; set; }

        public string FaceValue { get; set; }

        public string EyesValue { get; set; }

        public string EarsValue { get; set; }

        public string NoseValue { get; set; }

        public string MouthValue { get; set; }

        public string HeartValue { get; set; }

        public string ChestValue { get; set; }

        public string StomachValue { get; set; }

        public string AbdomenValue { get; set; }

        public string RectumValue { get; set; }

        public string UrinaryValue { get; set; }

        public string RespiratoryValue { get; set; }

        public string FeverValue { get; set; }

        public string ExtremitiesValue { get; set; }

        public string SkinValue { get; set; }

        public string MaleValue { get; set; }

        public string FemaleValue { get; set; }

        public string BackValue { get; set; }

        public string SleepValue { get; set; }

        public string ModalitiesValue { get; set; }

        public string RcompareValue { get; set; }

        public string RantidoteValue { get; set; }

        public string DoseValue { get; set; }

        public string ThroatValue { get; set; }

        public string SexualValue { get; set; }

        public string RgeneralValue { get; set; }

        public string UsesValue { get; set; }

        public string StoolValue { get; set; }

        public string TissuesValue { get; set; }

        public string NervesValue { get; set; }

        public string BonesValue { get; set; }

        public string TeethValue { get; set; }

        public string BowelsValue { get; set; }

        public string SpineValue { get; set; }

        public string BloodValue { get; set; }

        public string CirculatoryValue { get; set; }

        public string TongueValue { get; set; }

        public string BrestValue { get; set; }

        public string KidneyValue { get; set; }

        public string GastroValue { get; set; }

        public string SpleenValue { get; set; }

        public string NeckValue { get; set; }

        public string UrineValue { get; set; }

        public string PhysiologicDosageValue { get; set; }

        public string AlimentaryCanalValue { get; set; }

        public string RcompatibleValue { get; set; }

        public string RinimicalValue { get; set; }

        public string LiverValue { get; set; }

        public int Count { get; set; }


        internal string Substring(int index, int lenth)
        {
            throw new NotImplementedException();
        }

        internal string Substring(int p)
        {
            throw new NotImplementedException();
        }

      
    }
}


 