using UnityEngine;
using System.Collections;

public class SpawnControl : MonoBehaviour {

	public SpawnProperty spInstance;
	public GameObject prefab;

	public float spawnPointStart;
	public float spawnPointEnd;

	private GameObject spnInstance;
	private float spawnPoint;
	private Vector3 spawnPos;



	void Awake () {

		int totalweight = 0;
		for (int i = 0; i < spInstance.spawn.Length; i++)
			totalweight += spInstance.spawn [i].weight;

		int rw = Random.Range(0, totalweight);
		if (totalweight != 0)
			ColorWeighted (rw);
		else {
			int r = Random.Range (0, spInstance.spawn.Length);
			ColorRandom (r);
		}
	}
		

	void OnTriggerEnter2D (Collider2D playerColl) {
		
		if (playerColl.gameObject.tag == "Player")
			Spawn ();
		Destroy (GameObject.FindWithTag("Trigger"));
	}




	void ColorWeighted (int weight) {
		int index = 0;
		for (int j = 0; j < spInstance.spawn.Length; j++) {
			index += spInstance.spawn [j].weight;
			if (weight < index) {
				this.GetComponent<Renderer>().material.color = spInstance.spawn [j].color;
				break;
			}
		}
	}
		
	void ColorRandom (int r) {
		this.GetComponent<Renderer>().material.color = spInstance.spawn [r].color;
	}

	void Spawn () {
		spawnPoint = this.transform.position.x + Random.Range (Mathf.Abs (spawnPointStart), Mathf.Abs (spawnPointEnd));
		spawnPos = new Vector3 (spawnPoint, this.transform.position.y, this.transform.position.z);
		spnInstance = Instantiate (prefab, spawnPos, this.transform.rotation) as GameObject;
	}
}
