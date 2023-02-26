using System;
using System.Windows.Forms;

using IVSDKDotNet;

namespace IVToggleHudRadar {
    public class Main : Script {

        #region Variables
        private Keys toggleKey;
        #endregion

        #region Constructor
        public Main()
        {
            Initialized += Main_Initialized;
            KeyDown += Main_KeyDown;
        }
        #endregion

        private void Main_Initialized(object sender, EventArgs e)
        {
            toggleKey = Settings.GetKey("Main", "ToggleKey", Keys.X);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == toggleKey)
            {
                if (CMenuManager.Display.RadarMode == 0)
                {
                    CMenuManager.Display.RadarMode = 1;
                    CMenuManager.Display.HudOn = 1;
                }
                else
                {
                    CMenuManager.Display.RadarMode = 0;
                    CMenuManager.Display.HudOn = 0;
                }
            }
        }

    }
}
