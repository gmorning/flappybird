using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
	[SerializeField]
	private Text lastScore;

	[SerializeField]
	private Text maxScore;

	// Use this for initialization
	void Start () {
		lastScore.text = ScoreCounter.score.ToString ();
		maxScore.text = ScoreCounter.maxScore.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
