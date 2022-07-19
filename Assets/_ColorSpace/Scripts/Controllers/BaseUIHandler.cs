using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DotWolf.Colorspace.UI {
	public class BaseUIHandler : GenericSingleton<BaseUIHandler> {
		#region Declarations
		[Header("------ Required Assets ------")]
		[SerializeField] private Transform panelsContainer;
		[Space]
		[SerializeField] private int numberOfPanels;
		[SerializeField] protected int mainPanel = 0;

		public int MainPanel { get => mainPanel; }
		//Actions
		public  Action<int> OnPanelSwitch;
		public Action OnInitViews;
		//private - hidden
		[SerializeField]
		private int currentPanel;
        #endregion
        #region Unity Functions
        private void Start() {
			Init();
		}
        #endregion
        #region Functions
        /// <summary>
        /// Initialize all UI components an objects related to the scene
        /// </summary>
        public void Init() {
			if(numberOfPanels == 0) {
				GetPanels();
            }

			currentPanel = mainPanel;
			
			OnInitViews?.Invoke();

			ChangePanel(currentPanel);
		}
		/// <summary>
		/// Change the currentPanel index and launch panelswitched event 
		/// </summary>
		/// <param name="newPanel"></param>
		public void ChangePanel(int newPanel) {
			currentPanel = (newPanel);
			OnPanelSwitch?.Invoke(currentPanel);
        }
		/// <summary>
		/// Get all the child parented gameobects of the panelsContainer transform
		/// and store them at panelsList
		/// </summary>
		protected void GetPanels() {
			numberOfPanels = panelsContainer.childCount;
        }
		#endregion
	}
}