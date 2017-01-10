using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string playGameLevel;

	public void PlayGame()
	{
		SceneManager.LoadScene (playGameLevel);
//apparently obsolete now 
		//Application.LoadLevel (playGameLevel);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
	void start()
	{
		AdManager.Instance.ShowBanner ();
	}
		
}
