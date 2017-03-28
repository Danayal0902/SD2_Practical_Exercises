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

namespace Bank_Account
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declare your variables in the default constructor
        public double balance = 0;
        public double currentAmount = 0;

        public MainWindow()
        {

            InitializeComponent();
        }
        
        private void btnCredit_Click(object sender, RoutedEventArgs e)
        {
            //Convert the string to a double
            currentAmount = Double.Parse(txtAmount.Text);

            //Round the number to 2 decimal places
            currentAmount = Math.Round(currentAmount, 2);

            //Add the entered amount to the balance
            balance = (balance + currentAmount);

            //Display the new balance in the Text Block
            txtblkBalance.Text = ("Your balance is £" + balance);
            txtAmount.Text = ("");
        }

        
        
        
        private void btnDebit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                //Convert the string to a double
                currentAmount = Double.Parse(txtAmount.Text);

                //See if the new balance equals anything less than zero and catch it
                if ((currentAmount >= 0) && (balance - currentAmount) >= 0)
                {

                    //Round the number to 2 decimal places
                    currentAmount = Math.Round(currentAmount, 2);

                    //Subtract the entered amount from the balance
                    balance = (balance - currentAmount);

                    //Display the new balance in the Text Block
                    txtblkBalance.Text = ("Your balance is £" + balance);
                    txtAmount.Text = ("");
                }
                else
                {
                    MessageBox.Show("Please enter a real value you walaper");
                }
            }
                //Catch the exception and show an error message
            catch (Exception ex)
            {
                
            }
        }
    }
}
