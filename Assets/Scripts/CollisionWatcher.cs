using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionWatcher : MonoBehaviour 
{
	void OnCollisionEnter2D(Collision2D coll) 
	{
		SceneManager.LoadScene (2);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		EventManager.onTubesPass.Invoke ();
	}
}
