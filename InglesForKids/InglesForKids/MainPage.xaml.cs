using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InglesForKids
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btCores_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageColors());
        }

        private void btFamilia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageFamily());
        }

        private void btNumeros_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageNumbers());
        }
    }
}
