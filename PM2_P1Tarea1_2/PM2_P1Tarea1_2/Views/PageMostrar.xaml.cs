using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2_P1Tarea1_2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMostrar : ContentPage
    {
        public PageMostrar()
        {
            InitializeComponent();
        }

        public PageMostrar( String nombre, String apellido, String edad, String correo)
        {
            InitializeComponent();
            
        }
    }
}