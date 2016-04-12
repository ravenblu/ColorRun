using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public PlayerProperty ppInstance;
	public SpawnProperty spInstance;

	public float moveSpeed;


	void Awake () {

		ppInstance.player.rend.material.color = spInstance.spawn[0].color;
	}

	void Start () {
		
		ppInstance.player.rb.velocity = new Vector2 (moveSpeed, ppInstance.player.rb.velocity.y);
	}

	void Update () {
		
		ppInstance.player.rb.velocity = new Vector2 (moveSpeed, ppInstance.player.rb.velocity.y);

		//Change Player's Color
		for (int i = 0; i < spInstance.spawn.Length; i++) {
			if (Input.GetKeyDown (KeyCode.Keypad0 + i))
				ppInstance.player.rend.material.color = spInstance.spawn[i].color;
		}
			
	}
}
