using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DotWolf.Colorspace.UI {
	public class HomePanelController : PanelBase {
		#region Declarations
		[Header("Home Panel Components")]
		[SerializeField] private Button configBtn;
		[SerializeField] private Button shopBtn;
		[SerializeField] private Button shipBtn;
		[SerializeField] private Button scoreBoardBtn;
		[SerializeField] private Button playBtn;
		[SerializeField] private Button HowToPlayBtn;
        #endregion
        #region Unity Functions
        #endregion
        #region Functions
        protected override void Init()
        {
            base.Init();

			FindReferences();
			AddListeners();
        }
		/// <summary>
        /// Find all the references in the scene for the buttons if needed
        /// </summary>
        public void FindReferences()
        {
			///Find the ConfigBtn gameobject on the view
			Transform temp = view.transform.Find("ConfigBtn");
			///If the object its founded, we get its component and save it
            ///Else
            ///We show a Error Message
			if (temp != null)
				configBtn = temp.GetComponent<Button>();
			else
				Debug.LogError("There is no Config Button Named <color=#FB0000>ConfigBtn</color>");

			///Noew we repeate with the other objects
			temp = view.transform.Find("ShipBtn");
			if (temp != null)
				shipBtn = temp.GetComponent<Button>();
			else
				Debug.LogError("There is no Config Button Named <color=#FB0000>ShipBtn</color>");

			temp = view.transform.Find("ShopBtn");
			if (temp != null)
				shopBtn = temp.GetComponent<Button>();
			else
				Debug.LogError("There is no Config Button Named <color=#FB0000>ShopBtn</color>");

			temp = view.transform.Find("RecordBtn - Label");
			if (temp != null)
				scoreBoardBtn = temp.GetComponent<Button>();
			else
				Debug.LogError("There is no Config Button Named <color=#FB0000>RecordBtn - Label</color>");

			temp = view.transform.Find("PlayBtn");
			if (temp != null)
				playBtn = temp.GetComponent<Button>();
			else
				Debug.LogError("There is no Config Button Named <color=#FB0000>PlayBtn</color>");

			temp = view.transform.Find("HowToPlayBtn");
			if (temp != null)
				HowToPlayBtn = temp.GetComponent<Button>();
			else
				Debug.LogError("There is no Config Button Named <color=#FB0000>HowToPlayBtn</color>");

		}
		/// <summary>
        /// Add OnClick listener to all Basic Buttons
        /// </summary>
		private void AddListeners()
        {
			int mainPanelPos = BaseUIHandler.Instance.MainPanel;
			configBtn.onClick.AddListener(delegate {
				OpenPanel((int)Panels.Config + mainPanelPos);
			});
			shopBtn.onClick.AddListener(delegate {
				OpenPanel((int)Panels.Shop + mainPanelPos);
			});
			shipBtn.onClick.AddListener(delegate {
				OpenPanel((int)Panels.Ship + mainPanelPos);
			});
			scoreBoardBtn.onClick.AddListener(delegate {
				OpenPanel((int)Panels.Scoreboard + mainPanelPos);
			});
			HowToPlayBtn.onClick.AddListener(delegate {
				OpenPanel((int)Panels.HowToPlay + mainPanelPos);
			});
		}
		/// <summary>
        /// calls the ChangePanel action from Handler
        /// </summary>
        /// <param name="panel"></param>
		private void OpenPanel(int panel)
        {
			BaseUIHandler.Instance.ChangePanel(panel);
        }
		#endregion
	}
}