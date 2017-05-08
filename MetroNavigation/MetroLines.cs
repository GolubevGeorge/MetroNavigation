using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroNavigation
{
    class MetroLines
    {
        LocationCollection redLine = new LocationCollection();

        public LocationCollection  AddStations()
        {
            
            redLine.Add(new Location(50.464936, 30.355272000000014));
            redLine.Add(new Location(50.4560768, 30.364998199999945));
            redLine.Add(new Location(50.457771, 30.390584999999987));
            redLine.Add(new Location(50.458631, 30.403914999999984));
            redLine.Add(new Location(50.45927, 30.41901400000006));
            redLine.Add(new Location(50.454489, 30.447238999999968));
            redLine.Add(new Location(50.450953, 30.46514400000001));
            redLine.Add(new Location(50.44139, 30.489041000000043));
            redLine.Add(new Location(50.442925, 30.503717999999935));
            redLine.Add(new Location(50.444851, 30.516073000000006));
            redLine.Add(new Location(50.447056, 30.525360999999975));
            redLine.Add(new Location(50.443017, 30.547732999999994));
            redLine.Add(new Location(50.442203, 30.557758000000035));
            redLine.Add(new Location(50.445937, 30.57689400000004));
            redLine.Add(new Location(50.451877, 30.59816699999999));
            redLine.Add(new Location(50.45574509999999, 30.611898500000052));
            redLine.Add(new Location(50.45992099999999, 30.630374999999958));
            redLine.Add(new Location(50.464778, 30.645609000000036));

            return redLine;
        }
    }
}
