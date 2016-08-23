using UnityEngine;
using System.Collections;

public class MouseClickDetector : MonoBehaviour {

	public float jumpPower;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Rigidbody2D rb = GetComponent<Rigidbody2D> ();
			rb.velocity = Vector2.zero;
			rb.AddForce (Vector2.up * jumpPower);
		}
	}
}
