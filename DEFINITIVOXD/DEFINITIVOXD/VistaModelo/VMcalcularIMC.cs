using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DEFINITIVOXD.VistaModelo
{
    public class VMcalcularIMC : BaseViewModel
    {
        #region VARIABLES
        double _Peso;
        double _Altura;
        double _IMC;
        string _Mensaje;
        #endregion

        #region CONSTRUCTORES
        public VMcalcularIMC(INavigation navigation) 
        {
            Navigation = navigation;
        }

        #endregion

        #region OBJETOS
        public double Peso
        {
            get { return _Peso; }
            set { SetValue(ref _Peso, value); } 

        }
        public double Altura
        {
            get { return _Altura; }
            set {SetValue(ref _Altura, value); }
        }
        public double IMC
        {
            get { return _IMC; }
            set { SetValue(ref _IMC, value); }
        }
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        #endregion

        #region PROCESOS
        public void CalcularIMC(double p, double a)
        {
            IMC = p / (a*a);
        }
        
        public async void btnCalcular()
        {
            if(Peso == 0 || Altura == 0 && Peso == null ||  Altura == null)
            {
                await DisplayAlert("Alerta", "Por favor llene todos los campos", "Salir");
                return;
            }
            CalcularIMC(Peso,Altura);
            if (IMC < 18.5)
            {
                Mensaje = "Peso bajo";
            }
            else
            {
                if (IMC >= 18.5 && IMC <= 24.9)
                {
                    Mensaje = "Peso normal";
                }
                else
                {
                    if (IMC >= 25 && IMC <= 29.9)
                    {
                        Mensaje = "Sobrepeso";
                    }
                    else
                    {
                        Mensaje = "Obesidad";
                    }
                }
                await DisplayAlert("Estado", Mensaje, "Salir");
            }

           


        }

        #endregion

        #region COMANDOS
        public ICommand CalcularCommand => new Command(btnCalcular);

        #endregion
    }
}
