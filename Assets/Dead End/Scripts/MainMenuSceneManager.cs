using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSceneManager : MonoBehaviour 
{
    public void Start()
    {
        Cursor.visible = true;
    }
    public void LoadingScreen()
    {
        if (ApplicationManager.instance)
            ApplicationManager.instance.LoadingScreen();
    }

	/*public void LoadGame ()
	{
		if (ApplicationManager.instance)
			ApplicationManager.instance.LoadGame();
	}*/


	public void QuitGame()
	{
		if (ApplicationManager.instance)
			ApplicationManager.instance.QuitGame();
	}
	
}
