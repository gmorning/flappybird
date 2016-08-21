using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{	
	public void GoToScene(int index)
	{
		SceneManager.LoadScene (index);
	}
}
