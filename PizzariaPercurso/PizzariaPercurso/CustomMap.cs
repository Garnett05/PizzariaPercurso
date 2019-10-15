using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace PizzariaPercurso
{
    public class CustomMap : Map
    {
        public List<Position> RouteCoordinates { get; set; }

        public CustomMap()
        {
            RouteCoordinates = new List<Position>();
        }
    }
}
