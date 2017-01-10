using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	public AudioSource BGM;

	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
