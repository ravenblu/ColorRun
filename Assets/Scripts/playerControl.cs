using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {

	public Rigidbody2D rb;
	public Renderer rend;
	public GameObject SPR;

	public float moveSpeed;


	void Awake () {
		
		rend.material.color = Color.magenta;

	}

	void Start () {
		
		rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);

	}

	void Update () {
		
		rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);

		//Change Player's Color
		for (int i = 0; i < SPR.GetComponent<spawnProperty> ().sp.Length; i++) {
			if (Input.GetKeyDown (KeyCode.Keypad0 + i))
				rend.material.color = SPR.GetComponent<spawnProperty>().sp[i].color;
		}
			
	}
}
