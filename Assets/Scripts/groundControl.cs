using UnityEngine;
using System.Collections;

public class groundControl : MonoBehaviour {

	private Rigidbody2D rb;
	private float moveSpeed;

	void Awake () {
		
		rb = this.GetComponent<Rigidbody2D> ();

	}

	void Update () {
		
		moveSpeed = GameObject.FindGameObjectWithTag ("Player").GetComponent<playerControl> ().moveSpeed;

		rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);
	}

}
