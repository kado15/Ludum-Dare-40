using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour {
	public GameObject meteorToSpawn;
	public int maxMeteors;
	public List<GameObject> meteors;

	public float meteorSpeed;

	private float meteorSpawn;
	private float meteorCountdownTime;

	public float maxMeteorSpawnTime = 3;

	public Vector3 spawnLocation;
	// Use this for initialization
	void Start () {
		meteorSpawn = Random.Range (-9.5f, 9.5f);
		meteorCountdownTime = Random.Range (0f, maxMeteorSpawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		if (meteorCountdownTime > 0) {
			meteorCountdownTime -= Time.deltaTime;
		}
		if (meteorCountdownTime <= 0) {
			spawnLocation = new Vector3 (meteorSpawn, 8, 0);

			GameObject newMeteor = (GameObject)Instantiate (meteorToSpawn, spawnLocation, Quaternion.identity);
			newMeteor.SetActive (true);
			meteors.Add (newMeteor);

			meteorSpawn = Random.Range (-9.5f, 9.5f);
			if (maxMeteorSpawnTime >= .75f) {
				maxMeteorSpawnTime -= .05f;
			}
			meteorCountdownTime = Random.Range (0f, maxMeteorSpawnTime);
		}

		foreach (GameObject meteor in meteors) {
			meteor.transform.Translate(0, -meteorSpeed, 0);
		}
	}

	private void spawnMeteor() {
		GameObject newMeteor = (GameObject)Instantiate (meteorToSpawn);
	}
}
