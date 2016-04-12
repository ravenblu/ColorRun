using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	private GameObject player;
	private float dist;

	void Start () {
		player = GameObject.FindWithTag ("Player");
		dist = this.transform.position.x - player.transform.position.x;
	}

	void Update () {
		this.transform.position = new Vector3 (player.transform.position.x + dist, this.transform.position.y, this.transform.position.z);
	}
}
