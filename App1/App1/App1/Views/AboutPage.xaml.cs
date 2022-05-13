using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Random azar = new Random();

            //Para Que escoja un Color Automaticamente Tanto del Texto Interior del Boton Como del Borde y El Fondo
            (sender as Button).BackgroundColor = Color.FromRgb(azar.Next(256), azar.Next(256), azar.Next(256));
            (sender as Button).TextColor = Color.FromRgb(azar.Next(256), azar.Next(256), azar.Next(256));
            (sender as Button).BorderColor = Color.FromRgb(azar.Next(256), azar.Next(256), azar.Next(256));
        }
    }
}