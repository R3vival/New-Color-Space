using UnityEngine;
using UnityEngine.UI;

namespace DotWolf.Colorspace.UI {
	public class PanelBase : MonoBehaviour {
        #region Declarations
        [Header("Base Components")]
        [SerializeField] private int panelIndex;
        [SerializeField] protected GameObject view;
        #endregion
        #region Unity Functions        
        private void Awake() {
            BaseUIHandler.Instance.OnInitViews += Init;
        }
        private void OnDisable() {
            BaseUIHandler.Instance.OnPanelSwitch -= ChangePanel;
            BaseUIHandler.Instance.OnInitViews -= Init;
        }
        #endregion
        #region Functions
        /// <summary>
        /// Initialize the Panel Base component
        /// TODO:
        ///     IF the panelBase dosnt have childs, controll this exception
        /// </summary>
        protected virtual void Init() {
            panelIndex = transform.GetSiblingIndex(); ;

            view = transform.GetChild(0).gameObject;

            BaseUIHandler.Instance.OnPanelSwitch += ChangePanel;
        }
		protected void ChangePanel(int newPanel) {
            if (panelIndex == newPanel)
                view.SetActive(true);
            else
                view.SetActive(false);
        }
        [SerializeField]
        public void BackHome()
        {
            BaseUIHandler.Instance.ChangePanel(BaseUIHandler.Instance.MainPanel);
        }
        #endregion
        protected enum Panels
        {
            Home,
            Config,
            Shop,
            Ship,
            Scoreboard,
            HowToPlay,
        }
	}
}