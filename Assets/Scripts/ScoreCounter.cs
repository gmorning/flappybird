using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	private int score = 0;

	void OnEnable()
	{
		EventManager.onTubesPass += IncreaseScore;
	}

	void OnDisable()
	{
		EventManager.onTubesPass -= IncreaseScore;
	}

	void IncreaseScore()
	{
		score++;
//		var text = GetComponent<Text> ();
//		text.text = score.ToString();

		GetComponent<Text> ().text = score.ToString ();
	}
}
