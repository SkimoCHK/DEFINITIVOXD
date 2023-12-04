using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEFINITIVOXD.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DEFINITIVOXD.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcularView : ContentPage
    {
        public CalcularView()
        {
            InitializeComponent();
            BindingContext = new VMcalcularIMC(Navigation);
        }
    }
}