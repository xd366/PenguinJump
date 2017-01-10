using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Transform platformGenerator;
	private Vector3 platformStartPoint;

	public PlayerController thePlayer;
	private Vector3 playerStartPoint;

	private PlatformDestroyer[] platformList;
	private ScoreManager theScoreManager;

	public DeathMenu theDeathScreen;
	public WinMenu theWinScreen;

	void Start () {
		//AdManager.Instance.ShowBanner ();
		//AdManager.Instance.HideBanner();
		platformStartPoint = platformGenerator.position;
		playerStartPoint = thePlayer.transform.position;

		theScoreManager = FindObjectOfType<ScoreManager> ();
	}

	void Update () {
	
	}

	public void RestartGame()
	{
		theScoreManager.scoreIncreasing = false;
		thePlayer.gameObject.SetActive (false);
		AdManager.Instance.ShowBanner ();
		//not sure how to use ads yet


		theDeathScreen.gameObject.SetActive (true);
		//StartCoroutine ("RestartGameCo");	
	}

	public void FinishGame()
	{

		theScoreManager.scoreIncreasing = false;
		thePlayer.gameObject.SetActive (false);
		theWinScreen.gameObject.SetActive (true);

	}

	public void Reset()
	{
		theDeathScreen.gameObject.SetActive (false);
		theWinScreen.gameObject.SetActive (false);

		platformList = FindObjectsOfType<PlatformDestroyer> ();
		for(int i = 0; i < platformList.Length; i++)
		{
			platformList[i].gameObject.SetActive(false);
		}

		thePlayer.transform.position = playerStartPoint;
		platformGenerator.position = platformStartPoint;
		thePlayer.gameObject.SetActive (true);
		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;

	}

	/*public IEnumerator RestartGameCo()
	{
		theScoreManager.scoreIncreasing = false;
		thePlayer.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		platformList = FindObjectsOfType<PlatformDestroyer> ();
		for(int i = 0; i < platformList.Length; i++)
			{
				platformList[i].gameObject.SetActive(false);
			}

		thePlayer.transform.position = playerStartPoint;
		platformGenerator.position = platformStartPoint;
		thePlayer.gameObject.SetActive (true);
		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;
	}*/


}
