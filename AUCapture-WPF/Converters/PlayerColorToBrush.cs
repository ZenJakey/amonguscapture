﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using AmongUsCapture;

namespace AUCapture_WPF.Converters
{
    public class PlayerColorToBrush : IValueConverter
    {
        private static readonly Dictionary<PlayerColor, SolidColorBrush> BrushMapping = new() {
            { PlayerColor.Red,     new SolidColorBrush(Color.FromRgb(197, 17, 17))},
            { PlayerColor.Blue,    new SolidColorBrush(Color.FromRgb(19, 46, 209))},
            { PlayerColor.Green,   new SolidColorBrush(Color.FromRgb(17, 127, 45))},
            { PlayerColor.Pink,    new SolidColorBrush(Color.FromRgb(237, 84, 186))},
            { PlayerColor.Orange,  new SolidColorBrush(Color.FromRgb(239, 125, 13))},
            { PlayerColor.Yellow,  new SolidColorBrush(Color.FromRgb(245, 245, 87))},
            { PlayerColor.Black,   new SolidColorBrush(Color.FromRgb(63, 71, 78))},
            { PlayerColor.White,   new SolidColorBrush(Color.FromRgb(214, 224, 240))},
            { PlayerColor.Purple,  new SolidColorBrush(Color.FromRgb(107, 47, 187))},
            { PlayerColor.Brown,   new SolidColorBrush(Color.FromRgb(113, 73, 30))},
            { PlayerColor.Cyan,    new SolidColorBrush(Color.FromRgb(56, 254, 220))},
            { PlayerColor.Lime,     new SolidColorBrush(Color.FromRgb(80, 239, 57))},
            { PlayerColor.Watermelon,     new SolidColorBrush(Color.FromRgb(168, 50, 62))},
            { PlayerColor.Chocolate,     new SolidColorBrush(Color.FromRgb(60, 48, 44))},
            { PlayerColor.SkyBlue,     new SolidColorBrush(Color.FromRgb(61, 129, 255))},
            { PlayerColor.Beige,     new SolidColorBrush(Color.FromRgb(240, 211, 165))},
            { PlayerColor.HotPink,     new SolidColorBrush(Color.FromRgb(236, 61, 255))},
            { PlayerColor.Turquoise,     new SolidColorBrush(Color.FromRgb(61, 255, 181))},
            { PlayerColor.Lilac,     new SolidColorBrush(Color.FromRgb(186, 161, 255))},
            { PlayerColor.Rainbow,     new SolidColorBrush(Color.FromRgb(0, 0, 0))}

        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
             var color = value as PlayerColor? ?? PlayerColor.Red;
             return BrushMapping[color];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class PlayerColorToBrushShaded : IValueConverter
    {
        public static Color shadeColor(Color inColor, float percent) {
            
            float R = (inColor.R * (100 + percent)) / 100;
            float G = (inColor.G * (100 + percent)) / 100;
            float B = (inColor.B * (100 + percent)) / 100;
            R = R < 255 ? R : 255;
            G = G < 255 ? G : 255;
            B = B < 255 ? B : 255;
            return Color.FromArgb(255, (byte) R, (byte) G, (byte) B);
        }

        private static readonly Dictionary<PlayerColor, SolidColorBrush> BrushMapping = new() {
            { PlayerColor.Red,     new SolidColorBrush(Color.FromRgb(197, 17, 17))},
            { PlayerColor.Blue,    new SolidColorBrush(Color.FromRgb(19, 46, 209))},
            { PlayerColor.Green,   new SolidColorBrush(Color.FromRgb(17, 127, 45))},
            { PlayerColor.Pink,    new SolidColorBrush(Color.FromRgb(237, 84, 186))},
            { PlayerColor.Orange,  new SolidColorBrush(Color.FromRgb(239, 125, 13))},
            { PlayerColor.Yellow,  new SolidColorBrush(Color.FromRgb(245, 245, 87))},
            { PlayerColor.Black,   new SolidColorBrush(Color.FromRgb(63, 71, 78))},
            { PlayerColor.White,   new SolidColorBrush(Color.FromRgb(214, 224, 240))},
            { PlayerColor.Purple,  new SolidColorBrush(Color.FromRgb(107, 47, 187))},
            { PlayerColor.Brown,   new SolidColorBrush(Color.FromRgb(113, 73, 30))},
            { PlayerColor.Cyan,    new SolidColorBrush(Color.FromRgb(56, 254, 220))},
            { PlayerColor.Lime,     new SolidColorBrush(Color.FromRgb(80, 239, 57))},
            { PlayerColor.Watermelon,     new SolidColorBrush(Color.FromRgb(168, 50, 62))},
            { PlayerColor.Chocolate,     new SolidColorBrush(Color.FromRgb(60, 48, 44))},
            { PlayerColor.SkyBlue,     new SolidColorBrush(Color.FromRgb(61, 129, 255))},
            { PlayerColor.Beige,     new SolidColorBrush(Color.FromRgb(240, 211, 165))},
            { PlayerColor.HotPink,     new SolidColorBrush(Color.FromRgb(236, 61, 255))},
            { PlayerColor.Turquoise,     new SolidColorBrush(Color.FromRgb(61, 255, 181))},
            { PlayerColor.Lilac,     new SolidColorBrush(Color.FromRgb(186, 161, 255))},
            { PlayerColor.Rainbow,     new SolidColorBrush(Color.FromRgb(0, 0, 0))}

        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = value as PlayerColor? ?? PlayerColor.Red;
            var mainColor = BrushMapping[color];
            var shaded = shadeColor(mainColor.Color, -20f);
            return new SolidColorBrush(shaded);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
