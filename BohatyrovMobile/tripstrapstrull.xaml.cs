using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BohatyrovMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class tripstrapstrull : ContentPage
    {
        int counter = 0;
        Grid grid;
        Random random = new Random();
        Frame fr;
        public tripstrapstrull()
        {
            grid = new Grid
            {
                BackgroundColor = Color.LightBlue,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,

            };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped; ;
            tap.NumberOfTapsRequired = 1;
            grid.GestureRecognizers.Add(tap);


            for (int i = 0; i < 3; i++)
            {


                for (int j = 0; j < 3; j++)
                {
                    grid.Children.Add(
                        fr = new Frame
                        {
                            BackgroundColor = Color.Black,
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                            Margin = 5
                        }, i, j
                        );
                    fr.GestureRecognizers.Add(tap);
                }
                Content = grid;
            }
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            counter++;
            Label fr = (Label)sender;
            int r = Grid.GetRow( fr );
            int c = Grid.GetColumn(fr);
            if ( counter % 2==0 ) {
            
                if (Grid.GetRow(fr) == r && Grid.GetColumn(fr) ==c) {

                    fr.Text = "0";
                    fr.FontSize = 34;
                    fr.TextColor = Color.White;
                
                }
            
            }
            else
            {
                if (Grid.GetRow(fr)== r && Grid.GetColumn(fr)==c)
                {
                    fr.Text = "X";
                    fr.TextColor = Color.White;
                    fr.FontSize = 34;
                }
            }
           




        }
    }
}