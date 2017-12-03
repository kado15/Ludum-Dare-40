using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour {

	public float sizeOfScreenX;
	public float sizeOfScreenY;

	public float sizeOfSpriteX;
	public float sizeOfSpriteY;

	public float originalSizeX;
	public float originalSizeY;

	public Vector3 scale;

	private bool runOnce = true;

	public float X;
	public float Y;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scale = gameObject.transform.localScale;
		if (runOnce) {
			SpriteRenderer sr = GetComponent<SpriteRenderer> ();

			sizeOfScreenX = Screen.width;
			sizeOfScreenY = Screen.height;

			float spriteXConst = 342.1052631578947368421f;
			float spriteYConst = 258.4615384615384615385f;

			X = sizeOfScreenX / spriteXConst;
			Y = sizeOfScreenY / spriteYConst;

			gameObject.transform.localScale = new Vector3 (X, Y, 1);

			sizeOfSpriteX = gameObject.GetComponent<SpriteRenderer> ().bounds.size.x;
			sizeOfSpriteY = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;

			//gameObject.GetComponent<SpriteRenderer> ().bounds.size.x = X;
			//gameObject.GetComponent<SpriteRenderer> ().bounds.size.y = Y;


			//float cameraHeight = Camera.main.orthographicSize * 2f;
			//float cameraWidth = cameraHeight * Screen.width / Screen.height;

			//Vector3 scale = new Vector3 (sizeOfScreenX, sizeOfScreenY, 1);

			//gameObject.transform.localScale = scale * cameraHeight / 5.0f;
			//Width = 650 
			//Height = 336
			//SpriteWidth = 1.9
			//SpriteHeight = 1.3
			//sr.transform.localScale = new Vector3 (sizeOfScreenX, sizeOfScreenY, 1);
			runOnce = false;
		}
	}
}
