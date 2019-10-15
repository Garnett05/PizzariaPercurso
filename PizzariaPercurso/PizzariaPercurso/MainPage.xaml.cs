using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace PizzariaPercurso
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            customMap.RouteCoordinates.Add(new Position(-23.556697, -46.658699));
            customMap.RouteCoordinates.Add(new Position(-23.556275, -46.658246));
            customMap.RouteCoordinates.Add(new Position(-23.554071, -46.660794));
            customMap.RouteCoordinates.Add(new Position(-23.555211, -46.662184));

            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-23.555843, -46.660229), Distance.FromMiles(1.0)));
        }
    }
}
