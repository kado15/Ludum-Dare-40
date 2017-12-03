using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]

public class SpriteScaler : MonoBehaviour {

	void Start() {

	}
	void Update() {

	}
	void OnTriggerStay2D(Collider2D other) {
		if(other.name.Equals("Dinosaur")) {
			other.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		}
	}
}
