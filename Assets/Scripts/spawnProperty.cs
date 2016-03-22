using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class SProperty {
	public int weight;
	public Color color;
}


public class SpawnProperty : MonoBehaviour {
	public SProperty[] spawn;
}
