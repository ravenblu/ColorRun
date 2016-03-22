using UnityEngine;
using System.Collections;

public class spawnControl : MonoBehaviour {

	public Rigidbody2D spnPrefab;
	public Renderer spnRend;
	public Transform player;
	public GameObject SPR;

	public float spawnPointStart;
	public float spawnPointEnd;

	private GameObject spnInstance;
	private Vector3 spawnPos;
	private float spawnPoint;
	private spawnProperty spr;



	void Awake () {
		
		spr = SPR.GetComponent<spawnProperty> ();

		int totalweight = 0;
		for (int i = 0; i < spr.sp.Length; i++)
			totalweight += spr.sp [i].weight;

		int rw = Random.Range(0, totalweight);
		if (totalweight != 0)
			ColorWeighted (rw);
		else {
			int r = Random.Range (0, spr.sp.Length);
			ColorRandom (r);
		}
	}
		

	void OnTriggerEnter2D (Collider2D playerColl) {
		
		if (playerColl.gameObject.tag == "Player") {
			Spawn ();
		}
		Destroy (GameObject.FindWithTag("Trigger"));
	}




	void ColorWeighted (int weight) {
		int index = 0;
		for (int j = 0; j < spr.sp.Length; j++) {
			index += spr.sp [j].weight;
			if (weight < index) {
				spnRend.material.color = spr.sp [j].color;
				break;
			}
		}
	}

	void ColorRandom (int r) {
		spnRend.material.color = spr.sp [r].color;
	}

	void Spawn () {
		spawnPoint = this.transform.position.x + Random.Range (Mathf.Abs (spawnPointStart), Mathf.Abs (spawnPointEnd));
		spawnPos = new Vector3 (spawnPoint, this.transform.position.y, this.transform.position.z);
		spnInstance = Instantiate (spnPrefab, spawnPos, this.transform.rotation) as GameObject;
	}
}
