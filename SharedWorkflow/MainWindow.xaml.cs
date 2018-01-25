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

namespace SharedWorkflow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Boolean IsViewingPOC = false;
        public Boolean IsViewingRelatedTasks = false;
        public MainWindow()
        {
            InitializeComponent();
            
            dtagrdStaticData.ItemsSource = LoadCollectionData();
            //dtagrdSupportingTicketData.ItemsSource = LoadSupportingTicketData();
            dtagrdSupportingTicketDataTest.ItemsSource = LoadSupportingTicketData();
            dtagrdPOC.ItemsSource = LoadPointOfContactData();
        }


        public class StaticData
        {
            public int Store { get; set; }
            public string State { get; set; }
            public string Category { get; set; }
            public string DeviceName { get; set; }
        }

        private List<StaticData> LoadCollectionData()
        {
            List<StaticData> staticData = new List<StaticData>();

            staticData.Add(new StaticData()
            {

                Store = 2020,

                State = "AR",

                Category = "Hunting and Fishing",

                DeviceName = "MPT211711435955"
            });
            /*
            staticData.Add(new StaticData()
            {

                Store = 1234,

                State = "AL",

                Category = "Hunting and Fishing",

                DeviceName = "MPT211711435955"
            });
            */
            return staticData;
        }

        public class SupportingTicketData
        {
            public string TicketProvider { get; set; }
            public long TicketNumber { get; set; }            
        }

        private List<SupportingTicketData> LoadSupportingTicketData()
        {
            List<SupportingTicketData> supportingTicketData = new List<SupportingTicketData>();
            supportingTicketData.Add(new SupportingTicketData()
            {
                TicketProvider = "SRANDADDINGSOME",

                TicketNumber = 7735405765

            });
            supportingTicketData.Add(new SupportingTicketData()
            {
                TicketProvider = "ATT",

                TicketNumber = 12345678

            });
            supportingTicketData.Add(new SupportingTicketData()
            {
                TicketProvider = "SomethingCrazy",

                TicketNumber = 1234567891011111111

            });
            return supportingTicketData;
        }

        public class PointOfContactData
        {
            public string Name { get; set; }
            public long Number { get; set; }
        }

        private List<PointOfContactData> LoadPointOfContactData()
        {
            List<PointOfContactData> pointOfContactData = new List<PointOfContactData>();
            pointOfContactData.Add(new PointOfContactData()
            {
                Name = "John Williams",

                Number = 4794441100

            });
            pointOfContactData.Add(new PointOfContactData()
            {
                Name = "Cat Williams",

                Number = 4794442233

            });
            return pointOfContactData;
        }



        private void dtagrdSupportingTicketData_Loaded(object sender, RoutedEventArgs e)
        {
            /*
            int x = Convert.ToInt32(dtagrdSupportingTicketData.Columns[0].ActualWidth);           
            MessageBox.Show(x.ToString());           
            dtagrdSupportingTicketData.Columns[0].Width = new DataGridLength(dtagrdSupportingTicketData.Columns[0].ActualWidth);
            dtagrdSupportingTicketData.Columns[0].Header = "some very long header some very long header  some very long header";
            */
            // was looking at link below 
            //https://stackoverflow.com/questions/42366689/programmatically-change-datagrid-column-width-to-longest-size-of-cell-content
            

            //dtagrdSupportingTicketData.Columns[0].Width = new DataGridLength(dtagrdSupportingTicketData.Columns[0].ActualWidth);

            /*
            //commented out for code clean up
            dtagrdSupportingTicketData.ColumnWidth = DataGridLength.Auto;
            dtagrdSupportingTicketData.Width = dtagrdSupportingTicketData.Columns[0].ActualWidth + dtagrdSupportingTicketData.Columns[1].ActualWidth;
            */
            //drpdwnRelatedTaskTest.Width = dtagrdSupportingTicketData.Columns[0].ActualWidth + dtagrdSupportingTicketData.Columns[1].ActualWidth;

            //dtagrdSupportingTicketData.Columns[0].Width = DataGridLength.Auto;
            //make if loop to see if larger than header than adjust. 

        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void sizeDropDown()
        {
            GridLength x = new GridLength(1, GridUnitType.Auto);
            columnDefResizing.Width = x;
            //the below added auto resizing to the drop down
            /*
            double minimized = 130;
            
            if (!IsViewingPOC && !IsViewingRelatedTasks)
            {
                GridLength x = new GridLength(minimized);
                columnDefResizing.Width = x;
            }
            else
            {
                GridLength x = new GridLength(1, GridUnitType.Auto);
                columnDefResizing.Width = x;
            }
            */

            //could do an else to just set it to auto
            /*
            if (IsViewingPOC && !IsViewingRelatedTasks)
            {
                GridLength x = new GridLength(1, GridUnitType.Auto);
                columnDefResizing.Width = x;                
            }

            if (!IsViewingPOC && IsViewingRelatedTasks)
            {
                GridLength x = new GridLength(1, GridUnitType.Auto);
                columnDefResizing.Width = x;
            }
            */
        }

        public void  resizeDropDown()
        {
            GridLength x = new GridLength(1, GridUnitType.Auto);
            columnDefResizing.Width = x;
            //the below added auto resizing to the drop down
            /*
            double minimized = 130;

            if (!IsViewingPOC && !IsViewingRelatedTasks)
            {
                GridLength x = new GridLength(minimized);
                columnDefResizing.Width = x;
            }
            else if (IsViewingPOC && !IsViewingRelatedTasks)
            {
                double y = dtagrdPOC.ActualWidth + 20;
                GridLength x = new GridLength(y);
                columnDefResizing.Width = x;
                dtagrdPOC.Width = dtagrdPOC.ActualWidth;

            }
            else if (!IsViewingPOC && IsViewingRelatedTasks)
            {
                double y = dtagrdSupportingTicketDataTest.ActualWidth + 20;
                GridLength x = new GridLength(y);
                columnDefResizing.Width = x;
                dtagrdSupportingTicketDataTest.Width = dtagrdSupportingTicketDataTest.ActualWidth;

            }
            */
        }


        /*
extra code

private void btnDropDown_Click(object sender, RoutedEventArgs e)
{
   if (!dropDownActivated)
   {
       btnDropDown.Content = "5";
       dropDownActivated = true;
       MessageBox.Show((dtagrdSupportingTicketData.GetType()).ToString());
       dtagrdSupportingTicketData.Visibility = Visibility;               
       return;
   }
   else
   {
       btnDropDown.Content = "6";
       dropDownActivated = false;
       dtagrdSupportingTicketData.Visibility = Visibility.Collapsed;
   }           
}

private void btnDropDownPOC_Click(object sender, RoutedEventArgs e)
{
   if (!dropDownActivatedPOC)
   {
       btnDropDownPOC.Content = "5";
       dropDownActivatedPOC = true;
       dtagrdPOC.Visibility = Visibility;
       return;
   }
   else
   {
       btnDropDownPOC.Content = "6";
       dropDownActivatedPOC = false;
       dtagrdPOC.Visibility = Visibility.Collapsed;
   }
}

*/

    }
}
