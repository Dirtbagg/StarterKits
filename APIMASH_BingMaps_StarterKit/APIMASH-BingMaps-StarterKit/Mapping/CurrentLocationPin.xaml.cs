﻿using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

//
// LICENSE: http://opensource.org/licenses/ms-pl
//

namespace APIMASH_BingMaps_StarterKit.Mapping
{
    public sealed partial class CurrentLocationPin : UserControl, IAnchorable
    {
        //
        //
        // TODO: (optional) if the indicator graphic is changed, update the AnchorPoint to reflect what point in the 
        //       graphic should be anchored to the lat/long in the location.
        //
        /// <summary>
        /// Reflects the pixel offset into the graphic that defines the point to be associated with the given location.
        /// </summary>
        public Point AnchorPoint
        {
            get { return new Point(10, 10); }
        }

        public CurrentLocationPin()
        {
            this.InitializeComponent();
            Visibility = Visibility.Collapsed;
        }
    }
}