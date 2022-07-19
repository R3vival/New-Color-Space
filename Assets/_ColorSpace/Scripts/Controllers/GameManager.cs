using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : GenericSingleton<GameManager>
{
    #region Declarations
    //Singleton
    public static GameManager Instance;
    #endregion
    #region Unity Fucntions
    #endregion
    #region Functions
    /// <summary>
    /// Load the Scene Game instantly
    /// TODO:
    /// Load screen Controller and Move this to a GameManager
    /// </summary>
    public void StartGame()
    {
        //SceneManager.LoadScene();
    }
    #endregion
}
