﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CollisionWatcher : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) 
	{
		SceneManager.LoadScene (0);
	}
}