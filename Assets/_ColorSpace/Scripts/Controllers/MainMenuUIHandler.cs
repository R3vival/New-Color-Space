using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DotWolf.Colorspace.UI
{
    public class MainMenuUIHandler :BaseUIHandler
    {
        /// <summary>
        /// Change the current panel to Home hidding the other ones
        /// </summary>
		public void Home()
        {
            ChangePanel(mainPanel);
        }
        public enum Panels
        {
            Home,
            Configuration,
            Shop,
            Ship,
            Scoreboard,
            HowToPlay
        }
    }
}