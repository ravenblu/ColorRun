using UnityEngine;
using System.Collections;

[System.Serializable]
public class PProperty {
	public Rigidbody2D rb;
	public Renderer rend;
	public Transform trans;
}

public class PlayerProperty : MonoBehaviour {
	public PProperty player;


}
