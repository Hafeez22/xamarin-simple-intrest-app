using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace practice
{
    public partial class MainPage : ContentPage
    { 
        public MainPage()
        { 
            InitializeComponent();
        }

        private void Button_Clicked_Calculate(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(principle.Text) + Convert.ToDouble(principle.Text) * Convert.ToDouble(Months.Text) * Convert.ToDouble(intrest.Text) / 100;
            lbltotal.Text = total.ToString();
        }

        
    }
}
