using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try {
                double peso = Double.Parse(txt_peso.Text);
                double altura = Double.Parse(txt_altura.Text);

                double imc = peso / (altura * altura);

                String classificacao = "";  // delclarando uma variavel string com nome classificação

                if (imc < 17)
                {
                    classificacao = "Muito abaixo do peso";
                }
                else if (imc >= 17 && imc < 18.49)
                {
                    classificacao = "Abaixo do peso.";
                }
                else if(imc >= 18.50 && imc < 24.99)
                        {
                    classificacao = "com o Peso Normal. Parabéns!!";
                }
                else if (imc >= 25 && imc < 29.99)
                {
                    classificacao = "Acima do peso.";
                }
                else if(imc >= 30 && imc < 34.99)
                {
                    classificacao = "Obesidade I.";
                }
                else if (imc >= 35 && imc < 39.99)
                {
                    classificacao = "Obesidade II (severa).";
                }
                else if (imc >= 40)
                {
                    classificacao = "Obesidade III (morbida).";
                }

                resultado.Text = "Seu IMC é " + imc.ToString(("0.00")) + " e você está " + classificacao;
                resultado.TextColor = Color.Blue;
                resultado.HorizontalTextAlignment = TextAlignment.Center;

            }
            catch (Exception ex)
            {
                resultado.Text = "Desculpe, ocorreu um erro \n " + ex.Message;
            }
        }
    }
}
