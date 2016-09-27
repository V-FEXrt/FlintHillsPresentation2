using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public float spawnRate = 1.0f;

	public Transform spawnPrefab;

	// Use this for initialization

	private float spawnCooldown;

	void Start () {
		spawnCooldown = spawnRate;
	}
	
	// Update is called once per frame
	void Update () {
		spawnCooldown -= Time.deltaTime;
		if (spawnCooldown <= 0) {
			spawnCooldown = spawnRate;

			var prefab = Instantiate(spawnPrefab) as Transform;

			prefab.position = new Vector3 (10, Random.Range(0.0f, 11.0f));
		
		}
	
	}
}
