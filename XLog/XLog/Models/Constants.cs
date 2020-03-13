using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XLog.Models
{
    // This class needed to store static data
    public class Constants
    {
        public static bool IsDev = true;
        // Import "using Xamarin.Forms" for closs-platform Color
        public static Color BgColor = Color.FromRgb(211,241,245);
        public static Color TextColor = Color.Coral;
        public static int IconHeight = 120;

    }
}
