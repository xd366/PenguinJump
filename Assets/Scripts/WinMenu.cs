using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour {

	public string mainMenuLevel;
	public string endlessLevel;



	public void RestartGame()
	{
		FindObjectOfType<GameManager>().Reset();

	}

	public void PlayEndless ()
	{
		SceneManager.LoadScene (endlessLevel);
	}


	public void QuitToMain ()
	{
		SceneManager.LoadScene (mainMenuLevel);
	}

	//void Start () {
	//	AdManager.Instance.ShowBanner ();
	//}


}
