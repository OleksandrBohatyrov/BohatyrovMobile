using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;
using static System.Net.WebRequestMethods;

namespace BohatyrovMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lumememm : ContentPage
    {
       Ellipse puzo;
        public Lumememm()
        {

            puzo = new Ellipse
            {
                Fill = new SolidColorBrush(Color.White),
                StrokeThickness = 4,
                WidthRequest = 250,
                HeightRequest = 250,
                HorizontalOptions= LayoutOptions.Center,
                VerticalOptions= LayoutOptions.Fill
                
            };
            StackLayout st = new StackLayout
            {
                Children = { puzo }
            };
            Content = st;
        }
    }
}