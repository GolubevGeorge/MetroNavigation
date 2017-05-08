using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MetroNavigation
{

    public partial class MainWindow
    {
        LocationCollection locations = new MetroLines().AddStations();
        LocationCollection lc = new LocationCollection();
        int startIndex = 0;
        int endIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
            addImageToMap();
        }

        public void addImageToMap()
        {
            foreach (var location in locations)
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(@"/Resources/Metro.png", UriKind.Relative));
                image.Width = 30;
                image.Height = 30;
                image.Opacity = 0.6;

                MapLayer.SetPosition(image, location);
                MapLayer.SetPositionOrigin(image, PositionOrigin.BottomCenter);
                MainMap.Children.Add(image);

                image.MouseLeftButtonDown += Image_LeftButtonDown;
                image.MouseRightButtonDown += Image_MouseRightButtonDown;
            }

            MapPolyline polyLine = new MapPolyline();
            polyLine.Stroke = new SolidColorBrush(Colors.Red);
            polyLine.StrokeThickness = 6;
            polyLine.Opacity = 0.4;
            polyLine.Locations = locations;
            MainMap.Children.Add(polyLine);
        }

        private void Image_LeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            startIndex = locations.IndexOf(MapLayer.GetPosition(((Image)sender)));
        }

        private void Image_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            endIndex = locations.IndexOf(MapLayer.GetPosition(((Image)sender)));
            Calculate();
        }

        public void Calculate()
        {
            lc.Clear();

            foreach (var item in locations)
            {
                if (locations.IndexOf(item) >= startIndex & locations.IndexOf(item) <= endIndex)
                {
                    lc.Add(item);
                }
                else if (locations.IndexOf(item) >= endIndex & locations.IndexOf(item) <= startIndex)
                {
                    lc.Add(item);
                }
            }

            MapPolyline path = new MapPolyline();
            path.Stroke = new SolidColorBrush(Colors.Green);
            path.StrokeThickness = 10;
            path.Opacity = 1;
            path.Locations = lc;
            MainMap.Children.Remove(path);
            MainMap.Children.Add(path);
        }
    }
}

