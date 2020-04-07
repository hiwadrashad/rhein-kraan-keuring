using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;
using System.Drawing;



namespace Rhein_Kraan_Keuring
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
       
        int opdrachtnummer = 0;
        int maximumgecreerde = 0;
        Dictionary<int, List<string>> lengte6dlist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> lengte30dlist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> IDlist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> afslijpinglist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> roestlist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> diameterlist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> positielist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> beoordelinglist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> typelist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> typeroestlist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> kabelleverancierlist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> waarnemingenlist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> bedrijfsurenelist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> redenenlist = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> datelist = new Dictionary<int, List<string>>();
        Dictionary<int, string> imagepath = new Dictionary<int, string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

  
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           System.Windows.Application.Current.Shutdown();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filename = ofd.FileName;
                    filepath.Content = filename;
                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(filename, UriKind.Absolute);              
                    src.EndInit();
                    image1.Source = src;
                    
                    
                }
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show("foutmelding", "fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (opdrachtnummer > 0)
            {

               
                lengte6dlist[opdrachtnummer] = new List<string> { lenget6d1.Text, lenget6d2.Text, lenget6d3.Text, lenget6d4.Text, lenget6d5.Text };
                lengte30dlist[opdrachtnummer] = new List<string> { lenget30d1.Text, lenget30d2.Text, lenget30d3.Text, lenget30d4.Text, lenget30d5.Text };
                IDlist[opdrachtnummer] = new List<string> { id1.Text, id2.Text, id3.Text, id4.Text, id5.Text };
                afslijpinglist[opdrachtnummer] = new List<string> { afslijping1.Text, afslijping2.Text, afslijping3.Text, afslijping4.Text, afslijping5.Text };
                roestlist[opdrachtnummer] = new List<string> { corrosie1.Text, corrosie2.Text, corrosie3.Text, corrosie4.Text, corrosie5.Text };
                diameterlist[opdrachtnummer] = new List<string> { diameter2.Text, diameter3.Text, diameter3.Text, diameter4.Text, diameter5.Text };
                positielist[opdrachtnummer] = new List<string> { positie1.Text, positie2.Text, positie3.Text, positie4.Text, positie5.Text };
                beoordelinglist[opdrachtnummer] = new List<string> { totaal1.Text, totaal2.Text, totaal3.Text, totaal4.Text, totaal5.Text };
                typelist[opdrachtnummer] = new List<string> { beschadiging1.Text, beschadiging2.Text, beschadiging3.Text, beschadiging4.Text, beschadiging5.Text };
                typeroestlist[opdrachtnummer] = new List<string> { roest1.Text, roest2.Text, roest3.Text, roest4.Text, roest5.Text };
                kabelleverancierlist[opdrachtnummer] = new List<string> { kabelleverancier1.Text};
                waarnemingenlist[opdrachtnummer] = new List<string> { waarnemingen1.Text};
                bedrijfsurenelist[opdrachtnummer] = new List<string> { bedrijfsuren1.Text};
                redenenlist[opdrachtnummer] = new List<string> { redenen1.Text};
                datelist[opdrachtnummer] = new List<string> { Convert.ToString(label3.Content) };
                imagepath[opdrachtnummer] = Convert.ToString(filepath.Content);

                opdrachtnummer = opdrachtnummer - 1;
                nummer.Content = Convert.ToString(opdrachtnummer);

                var lengte = lengte6dlist[opdrachtnummer];
                var lengte30 = lengte30dlist[opdrachtnummer];
                var Id = IDlist[opdrachtnummer];
                var afslijping = afslijpinglist[opdrachtnummer];
                var roest = roestlist[opdrachtnummer];
                var diameter = diameterlist[opdrachtnummer];
                var positie = positielist[opdrachtnummer];
                var beoordeling = beoordelinglist[opdrachtnummer];
                var type = typelist[opdrachtnummer];
                var typeroest = typeroestlist[opdrachtnummer];
                var leverancier = kabelleverancierlist[opdrachtnummer];
                var waarnemingen = waarnemingenlist[opdrachtnummer];
                var uren = bedrijfsurenelist[opdrachtnummer];
                var reden = redenenlist[opdrachtnummer];
                var datum = datelist[opdrachtnummer];
                var imageobj = imagepath[opdrachtnummer];

                lenget6d1.Text = lengte[0];
                lenget6d2.Text = lengte[1];
                lenget6d3.Text = lengte[2];
                lenget6d4.Text = lengte[3];
                lenget6d5.Text = lengte[4];

                //lengte30d
                lenget30d1.Text = lengte30[0];
                lenget30d2.Text = lengte30[1];
                lenget30d3.Text = lengte30[2];
                lenget30d4.Text = lengte30[3];
                lenget30d5.Text = lengte30[4];

                //id
                id1.Text = Id[0];
                id2.Text = Id[1];
                id3.Text = Id[2];
                id4.Text = Id[3];
                id5.Text = Id[4];
                //aflsijping
                afslijping1.Text = afslijping[0];
                afslijping2.Text = afslijping[1];
                afslijping3.Text = afslijping[2];
                afslijping4.Text = afslijping[3];
                afslijping5.Text = afslijping[4];
                //corrosie
                corrosie1.Text = roest[0];
                corrosie2.Text = roest[1];
                corrosie3.Text = roest[2];
                corrosie4.Text = roest[3];
                corrosie5.Text = roest[4];
                //diameter
                diameter1.Text = diameter[0];
                diameter2.Text = diameter[1];
                diameter3.Text = diameter[2];
                diameter4.Text = diameter[3];
                diameter5.Text = diameter[4];
                //positie
                positie1.Text = positie[0];
                positie2.Text = positie[1];
                positie3.Text = positie[2];
                positie4.Text = positie[3];
                positie5.Text = positie[4];
                //totaal
                totaal1.Text = beoordeling[0];
                totaal2.Text = beoordeling[1];
                totaal3.Text = beoordeling[2];
                totaal4.Text = beoordeling[3];
                totaal5.Text = beoordeling[4];
                //beschadiging
                beschadiging1.Text = type[0];
                beschadiging2.Text = type[1];
                beschadiging3.Text = type[2];
                beschadiging4.Text = type[3];
                beschadiging5.Text = type[4];
                //roest
                roest1.Text = typeroest[0];
                roest2.Text = typeroest[1];
                roest3.Text = typeroest[2];
                roest4.Text = typeroest[3];
                roest5.Text = typeroest[4];
                //datum*
                //kabelleverancier
                kabelleverancier1.Text = leverancier[0];
                //waarnemingen
                waarnemingen1.Text = waarnemingen[0];
                //handtekening*
                //bedrijfsuren
                bedrijfsuren1.Text = uren[0];
                //redenen
                redenen1.Text = reden[0];
                //datum
                label3.Content = datum[0];
                //image
                if (imageobj == "")
                {
                    image1.Source = null;
                    filepath.Content = "";
                }
                else
                {
                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(imageobj, UriKind.Absolute);
                    src.EndInit();
                    image1.Source = src;
                    filepath.Content = imageobj;
                }

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
          

            lengte6dlist[opdrachtnummer] = new List<string> { lenget6d1.Text, lenget6d2.Text, lenget6d3.Text, lenget6d4.Text, lenget6d5.Text };
            lengte30dlist[opdrachtnummer] = new List<string> { lenget30d1.Text, lenget30d2.Text, lenget30d3.Text, lenget30d4.Text, lenget30d5.Text };
            IDlist[opdrachtnummer] = new List<string> { id1.Text, id2.Text, id3.Text, id4.Text, id5.Text };
            afslijpinglist[opdrachtnummer] = new List<string> { afslijping1.Text, afslijping2.Text, afslijping3.Text, afslijping4.Text, afslijping5.Text };
            roestlist[opdrachtnummer] = new List<string> { corrosie1.Text, corrosie2.Text, corrosie3.Text, corrosie4.Text, corrosie5.Text };
            diameterlist[opdrachtnummer] = new List<string> { diameter2.Text, diameter3.Text, diameter3.Text, diameter4.Text, diameter5.Text };
            positielist[opdrachtnummer] = new List<string> { positie1.Text, positie2.Text, positie3.Text, positie4.Text, positie5.Text };
            beoordelinglist[opdrachtnummer] = new List<string> { totaal1.Text, totaal2.Text, totaal3.Text, totaal4.Text, totaal5.Text };
            typelist[opdrachtnummer] = new List<string> { beschadiging1.Text, beschadiging2.Text, beschadiging3.Text, beschadiging4.Text, beschadiging5.Text };
            typeroestlist[opdrachtnummer] = new List<string> { roest1.Text, roest2.Text, roest3.Text, roest4.Text, roest5.Text };
            kabelleverancierlist[opdrachtnummer] = new List<string> { kabelleverancier1.Text };
            waarnemingenlist[opdrachtnummer] = new List<string> { waarnemingen1.Text };
            bedrijfsurenelist[opdrachtnummer] = new List<string> { bedrijfsuren1.Text };
            redenenlist[opdrachtnummer] = new List<string> { redenen1.Text };
            datelist[opdrachtnummer] = new List<string> { Convert.ToString(label3.Content)};
            imagepath[opdrachtnummer] = Convert.ToString(filepath.Content);


            opdrachtnummer = opdrachtnummer + 1;
            nummer.Content = Convert.ToString(opdrachtnummer);

            if (maximumgecreerde < opdrachtnummer)
            {
                maximumgecreerde = opdrachtnummer;
                lenget6d1.Clear();
                lenget6d2.Clear();
                lenget6d3.Clear();
                lenget6d4.Clear();
                lenget6d5.Clear();

                lenget30d1.Clear();
                lenget30d2.Clear();
                lenget30d3.Clear();
                lenget30d4.Clear();
                lenget30d5.Clear();

                id1.Clear();
                id2.Clear();
                id3.Clear();
                id4.Clear();
                id5.Clear();

                afslijping1.Clear();
                afslijping2.Clear();
                afslijping3.Clear();
                afslijping4.Clear();
                afslijping5.Clear();

                corrosie1.Clear();
                corrosie2.Clear();
                corrosie3.Clear();
                corrosie4.Clear();
                corrosie5.Clear();

                diameter1.Clear();
                diameter2.Clear();
                diameter3.Clear();
                diameter4.Clear();
                diameter5.Clear();

                positie1.Clear();
                positie2.Clear();
                positie3.Clear();
                positie4.Clear();
                positie5.Clear();

                totaal1.Clear();
                totaal2.Clear();
                totaal3.Clear();
                totaal4.Clear();
                totaal5.Clear();

                beschadiging1.Clear();
                beschadiging2.Clear();
                beschadiging3.Clear();
                beschadiging4.Clear();
                beschadiging5.Clear();

                roest1.Clear();
                roest2.Clear();
                roest3.Clear();
                roest4.Clear();
                roest5.Clear();

                kabelleverancier1.Clear();


                waarnemingen1.Clear();


                bedrijfsuren1.Clear();


                redenen1.Clear();

                label3.Content = "";

                image1.Source = null;
                filepath.Content = "";

            }
            else
            {
                    var lengte = lengte6dlist[opdrachtnummer];
                    lenget6d1.Text = lengte[0];
                    lenget6d2.Text = lengte[1];
                    lenget6d3.Text = lengte[2];
                    lenget6d4.Text = lengte[3];
                    lenget6d5.Text = lengte[4];

                    var lengte30 = lengte30dlist[opdrachtnummer];
                    lenget30d1.Text = lengte30[0];
                lenget30d2.Text = lengte30[1];
                lenget30d3.Text = lengte30[2];
                lenget30d4.Text = lengte30[3];
                lenget30d5.Text = lengte30[4];

                var idobj = IDlist[opdrachtnummer];
                id1.Text = idobj[0];
                id2.Text = idobj[1];
                id3.Text = idobj[2];
                id4.Text = idobj[3];
                id5.Text = idobj[4];

                var afslijpingobj = afslijpinglist[opdrachtnummer];
                afslijping1.Text = afslijpingobj[0];
                afslijping2.Text = afslijpingobj[1];
                afslijping3.Text = afslijpingobj[2];
                afslijping4.Text = afslijpingobj[3];
                afslijping5.Text = afslijpingobj[4];

                var corossieobj = roestlist[opdrachtnummer];
                corrosie1.Text = corossieobj[0];
                corrosie2.Text = corossieobj[1];
                corrosie3.Text = corossieobj[2];
                corrosie4.Text = corossieobj[3];
                corrosie5.Text = corossieobj[4];

                var diameterobj = diameterlist[opdrachtnummer];
                diameter1.Text = diameterobj[0];
                diameter2.Text = diameterobj[1];
                diameter3.Text = diameterobj[2];
                diameter4.Text = diameterobj[3];
                diameter5.Text = diameterobj[4];

                var positieobj = positielist[opdrachtnummer];
                positie1.Text = positieobj[0];
                positie2.Text = positieobj[1];
                positie3.Text = positieobj[2];
                positie4.Text = positieobj[3];
                positie5.Text = positieobj[4];

                var totaalobj = beoordelinglist[opdrachtnummer];
                totaal1.Text = totaalobj[0];
                totaal2.Text = totaalobj[1];
                totaal3.Text = totaalobj[2];
                totaal4.Text = totaalobj[3];
                totaal5.Text = totaalobj[4];

                var beschadigingobj = typelist[opdrachtnummer];
                beschadiging1.Text = beschadigingobj[0];
                beschadiging2.Text = beschadigingobj[1];
                beschadiging3.Text = beschadigingobj[2];
                beschadiging4.Text = beschadigingobj[3];
                beschadiging5.Text = beschadigingobj[4];

                var roestobj = typeroestlist[opdrachtnummer];
                roest1.Text = roestobj[0];
                roest2.Text = roestobj[1];
                roest3.Text = roestobj[2];
                roest4.Text = roestobj[3];
                roest5.Text = roestobj[4];

                var leverancierobj = kabelleverancierlist[opdrachtnummer];
                kabelleverancier1.Text = leverancierobj[0];

                var waarnemingenobj = waarnemingenlist[opdrachtnummer];
                waarnemingen1.Text = waarnemingenobj[0];

                var urenobj = bedrijfsurenelist[opdrachtnummer];
                bedrijfsuren1.Text = urenobj[0];

                var redenenobj = redenenlist[opdrachtnummer];
                redenen1.Text = redenenobj[0];

                var datumobj = datelist[opdrachtnummer];
                label3.Content = datumobj[0];

                var imageobj2 = imagepath[opdrachtnummer];
                if (imageobj2 == "")
                {
                    image1.Source = null;
                    filepath.Content = "";
                }
                else
                {
                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(imageobj2, UriKind.Absolute);
                    src.EndInit();
                    image1.Source = src;
                    filepath.Content = imageobj2;
                }

            }



        }

        private void datum1_CalendarClosed(object sender, RoutedEventArgs e)
        {
            string savedate;

            try
            {
                savedate = datum1.SelectedDate.Value.Date.ToShortDateString().ToString();
            }
            catch (InvalidOperationException exception)
            {
                savedate = "";
            }

            label3.Content = savedate;
        }
    }
}

