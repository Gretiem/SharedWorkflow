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
using System.ComponentModel;

namespace SharedWorkflow
{
    /// <summary>
    /// Interaction logic for custDropDown.xaml
    /// </summary>
    public partial class custDropDown : UserControl, INotifyPropertyChanged
    {
        Boolean dropDownActivated = false;
        Boolean dropDownActivatedPOC = false;

        #region Custom Properties

        public String LblContentValue
        {
            get { return (String)GetValue(LblContentValueProperty); }
            set { SetValue(LblContentValueProperty, value); }
        }

        public static DependencyProperty LblContentValueProperty = DependencyProperty.Register("LblContentValue", typeof(string), typeof(custDropDown), new UIPropertyMetadata(null));

        public String DataGridTargetValue
        {
            get { return (String)GetValue(DataGridValueProperty); }
            set { SetValue(DataGridValueProperty, value); }
        }

        public static DependencyProperty DataGridValueProperty = DependencyProperty.Register("DataGridValue", typeof(string), typeof(custDropDown), new UIPropertyMetadata(null));

        #endregion Custom Properties

        #region INotifyVariables
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisedNotifityChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _dataGridTarget;
        public string DataGridTarget
        {
            get { return _dataGridTarget; }
            set
            {
                _dataGridTarget = value;
                RaisedNotifityChanged("DataGridTarget");
            }
        }
        


        #endregion INotifyVariables

        public custDropDown()
        {
            InitializeComponent();
        }

        private void btnDropDown_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridTargetValue == "dtagrdSupportingTicketDataTest")
            {
                //MessageBox.Show("It's a match");

                if (!dropDownActivated)
                {
                    btnDropDown.Content = "5";
                    dropDownActivated = true;
                    var mainWindow = Application.Current.MainWindow as MainWindow;
                    mainWindow.dtagrdSupportingTicketDataTest.Visibility = Visibility;

                    mainWindow.IsViewingRelatedTasks = true;
                    mainWindow.sizeDropDown();
                   


                    return;
                }
                else
                {
                    btnDropDown.Content = "6";
                    var mainWindow = Application.Current.MainWindow as MainWindow;
                    mainWindow.dtagrdSupportingTicketDataTest.Visibility = Visibility.Collapsed;
                    /*
                    double y = cddLabel.Width;
                    GridLength x = new GridLength(y);
                    mainWindow.columnDefResizing.Width = x;
                    */                    
                    dropDownActivated = false;

                    mainWindow.IsViewingRelatedTasks = false;
                    //mainWindow.sizeDropDown();
                    mainWindow.resizeDropDown();
                }
            }
            else if(DataGridTargetValue == "dtagrdPOC")
            {
                if (!dropDownActivatedPOC)
                {
                    btnDropDown.Content = "5";
                    dropDownActivatedPOC = true;
                    var mainWindow = Application.Current.MainWindow as MainWindow;
                    mainWindow.dtagrdPOC.Visibility = Visibility;
                    mainWindow.IsViewingPOC = true;
                    mainWindow.sizeDropDown();
                    
                    return;
                }
                else
                {
                    btnDropDown.Content = "6";
                    var mainWindow = Application.Current.MainWindow as MainWindow;
                    mainWindow.dtagrdPOC.Visibility = Visibility.Collapsed;                    
                    dropDownActivatedPOC = false;

                    mainWindow.IsViewingPOC = false;
                    //mainWindow.sizeDropDown();
                    mainWindow.resizeDropDown();
                }
            }
            else
            {
                MessageBox.Show("Doesn't match");
            }

           
        }



       
    }
}
