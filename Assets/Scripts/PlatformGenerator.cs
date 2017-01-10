using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour {

	public GameObject thePlatform;
	public Transform generationPoint;
	public float distanceBetween;
	private float platformWidth;
	public float distanceBetweenMin;
	public float distanceBetweenMax;

	//public GameObject[] thePlatforms;
	private int platformSelector;
	private float[] platformWidths;

	public ObjectPooler[] theObjectPools;

	private float minHeight;
	public Transform maxHeightPoint;
	private float maxHeight;
	public float maxHeightChange;
	private float heightChange;



	void Start () {
		//platformWidth = thePlatform.GetComponent<BoxCollider2D> ().size.x;

		platformWidths = new float[theObjectPools.Length];

		for (int i = 0; i < theObjectPools.Length; i++) 
		{
			platformWidths [i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D> ().size.x;
		}

		minHeight = transform.position.y;
		maxHeight = maxHeightPoint.position.y;


	}

	void Update () {
		if (transform.position.x < generationPoint.position.x) 
		{
			distanceBetween = Random.Range (distanceBetweenMin, distanceBetweenMax);	
			platformSelector = Random.Range (0, theObjectPools.Length);
			heightChange = transform.position.y + Random.Range (maxHeightChange, -maxHeightChange);
			if (heightChange > maxHeight)
			{
				heightChange = maxHeight;
			} 
			else if (heightChange < minHeight) 
			{
				heightChange = minHeight;
			}
				
			transform.position = new Vector3 (transform.position.x + (platformWidths[platformSelector] / 2) + distanceBetween, heightChange, transform.position.z);
						
			//Instantiate (/*thePlatform*/ thePlatforms[platformSelector], transform.position, transform.rotation);
			//this would create platforms and then dstroy them. changed to object pool

			GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();
		
			newPlatform.transform.position = transform.position;
			newPlatform.transform.rotation = transform.rotation;
			newPlatform.SetActive (true);
	
			transform.position = new Vector3 (transform.position.x + (platformWidths[platformSelector] / 2), transform.position.y, transform.position.z);
}
	}
}
