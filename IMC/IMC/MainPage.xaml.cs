using System;
using Xamarin.Forms;

namespace IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calcula_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(eAltura.Text) && !string.IsNullOrEmpty(ePeso.Text))
            {
                double altura = double.Parse(eAltura.Text);
                double peso = double.Parse(ePeso.Text);

                double resultado = peso / (altura * altura);
                eResultado.Text = resultado.ToString();

                string mensaje;

                if (resultado < 18.5)
                {
                    mensaje = "Estas bajo en peso.";
                }
                else if (resultado >= 18.5 && resultado <= 24.9)
                {
                    mensaje = "Tu peso es ideal.";
                }
                else if (resultado >= 25 && resultado <= 29.9)
                {
                    mensaje = "Tienes sobrepeso!";
                }
                else
                {
                    mensaje = "Cuidate! tienes obesidad";
                }

                DisplayAlert("Resultado", mensaje, "OK");
            }
            else
            {
                DisplayAlert("Error", "Favor de revisar los datos.", "OK");
            }
        }
    }
}
