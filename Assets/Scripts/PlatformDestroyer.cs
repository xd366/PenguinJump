using UnityEngine;
using System.Collections;

public class PlatformDestroyer : MonoBehaviour {

	public GameObject platformDestructionPoint;

	void Start () {
		platformDestructionPoint = GameObject.Find ("PlatformDestructionPoint");
	}
	

	void Update () {
		if (transform.position.x < platformDestructionPoint.transform.position.x) 
		{
		
			//	Destroy (gameObject);
			// changing to Object Pooling instead


			gameObject.SetActive (false);

		}
	}
}
