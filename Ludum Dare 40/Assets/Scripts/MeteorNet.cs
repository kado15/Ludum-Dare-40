using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorNet : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag.Equals("Meteor")) {

			MeteorController.FindObjectOfType<MeteorController> ().meteors.Remove (other.gameObject);
			Destroy(other.gameObject);
			UIManager.FindObjectOfType<UIManager> ().scoreNumber++;
		}
	}
}
