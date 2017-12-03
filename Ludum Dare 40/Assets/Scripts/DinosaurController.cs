using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurController : MonoBehaviour {

	public float startSpeed;
	public float dinoSpeed;

	public bool isAlive;

	private float moveInput;
	private Animator anim;

	// Use this for initialization
	void Start () {
		dinoSpeed = startSpeed;
		isAlive = true;

		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isAlive) {
			moveInput = Input.GetAxisRaw ("Horizontal");
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveInput * dinoSpeed, 0f);
			if (moveInput > 0f) {
				anim.SetFloat ("Direction", 1);// right
			} else if(moveInput < 0f) {
				anim.SetFloat ("Direction", 0);//left
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if(other.tag.Equals("Meteor")) {
			Destroy (gameObject);
		}
		InputField.FindObjectOfType<InputField> ().loadMenu ();
	}

}
