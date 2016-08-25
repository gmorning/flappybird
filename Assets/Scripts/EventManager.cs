using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour 
{
	public delegate void OnTubesPass();
	public static OnTubesPass onTubesPass;
}
