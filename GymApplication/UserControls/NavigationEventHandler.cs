using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymApplication.UserControls
{
    public class NavigationEventHandler : EventArgs
    {
        Guna.UI.WinForms.GunaButton OldButton { get; set; }
        Guna.UI.WinForms.GunaButton NewButton { get; set; }
        public NavigationEventHandler(ref Guna.UI.WinForms.GunaButton old, ref Guna.UI.WinForms.GunaButton _new)
        {
            OldButton = old;
            NewButton = _new;
        }
    }
}
