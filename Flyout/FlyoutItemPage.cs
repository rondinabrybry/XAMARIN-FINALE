using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Flyout
{
    internal class FlyoutItemPage
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetPage {  get; set; }
    }
}
