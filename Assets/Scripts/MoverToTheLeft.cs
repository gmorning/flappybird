using UnityEngine;
using System.Collections;

public class MoverToTheLeft : MonoBehaviour {

	public float speed;
	public GameObject prefab;
	public float heightVariation;

	private bool spawnedNext = false;

	// Update is called once per frame
	void Update () 
	{
		transform.position += Vector3.left * speed;

		if (!spawnedNext && transform.position.x < 0) {
			spawnedNext = true;
			var tubePair = Instantiate (prefab);
			tubePair.transform.position = Vector3.right * 4 + Vector3.down * heightVariation + Vector3.up * Random.value * heightVariation * 2;
		}

		if (transform.position.x < -5)
			Destroy (gameObject);
	}
}
