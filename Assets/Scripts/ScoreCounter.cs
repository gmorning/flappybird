using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
	public static int score = 0;
	public static int maxScore = 0;


	void OnEnable()
	{
		score = 0;
		EventManager.onTubesPass += IncreaseScore;
	}

	void OnDisable()
	{
		EventManager.onTubesPass -= IncreaseScore;
	}

	void IncreaseScore()
	{
		if (++score > maxScore)
			maxScore = score;

		GetComponent<Text> ().text = score.ToString ();
	}
}
