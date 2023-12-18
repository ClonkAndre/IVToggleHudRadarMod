using System;
using System.Windows.Forms;

using IVSDKDotNet;

namespace IVToggleHudRadar
{
    public class Main : Script
    {

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
                if (IVMenuManager.RadarMode == 0)
                {
                    IVMenuManager.RadarMode = 1;
                    IVMenuManager.HudOn = true;
                }
                else
                {
                    IVMenuManager.RadarMode = 0;
                    IVMenuManager.HudOn = false;
                }
            }
        }

    }
}
