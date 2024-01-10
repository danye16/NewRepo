using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CRITICOGRAFO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e) //Alto
        {
        }
       string genero;
        string Palabra;
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            string nombre = Apodo.Text;
            if (Hombre.IsChecked)
            {
                genero = "MACHO";
            }
            if (Mujer.IsChecked)
            {
                genero = "Mujer";
            }

            
            if (genero=="MACHO")
            {
                if (Alto.IsChecked)
                {
                    Palabra = "Alto";
                }
                if (Feo.IsChecked)
                {
                    Palabra += "Feo";
                }
                if (Listo.IsChecked)
                {
                    Palabra += "Listo";
                }
                if (Extravagante.IsChecked)
                {
                    Palabra += "Extravagante";
                }
                if (Raro.IsChecked)
                {
                    Palabra += "Raro";
                }
                if (Grande.IsChecked)
                {
                    Palabra += "Grande";
                }
            }
            if (genero == "Mujer")
            {
                if (Alto.IsChecked)
                {
                    Palabra = "Alta";
                }
                if (Feo.IsChecked)
                {
                    Palabra += "Fea";
                }
                if (Listo.IsChecked)
                {
                    Palabra += "Lista";
                }
                if (Extravagante.IsChecked)
                {
                    Palabra += "Extravaganta";
                }
                if (Raro.IsChecked)
                {
                    Palabra += "Rara";
                }
                if (Grande.IsChecked)
                {
                    Palabra += "Granda";
                }
            }

            string resultado = nombre + Palabra;

            string[] resultadofinal = resultado.Split(new char[] {})

            Resultado.Text=resultado.ToString();
        }

        private void CheckBox_CheckedChanged_1(object sender, CheckedChangedEventArgs e)//Feo
        {

        }

        private void CheckBox_CheckedChanged_2(object sender, CheckedChangedEventArgs e)//Listo
        {

        }

        private void CheckBox_CheckedChanged_3(object sender, CheckedChangedEventArgs e)//Extravagante
        {

        }

        private void CheckBox_CheckedChanged_4(object sender, CheckedChangedEventArgs e)//Raro
        {

        }
        
        private void CheckBox_CheckedChanged_5(object sender, CheckedChangedEventArgs e) //Grande
        {

        }
    }
}
