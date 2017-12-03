using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputField : MonoBehaviour {
	public void loadLevel() {
		Application.LoadLevel ("Classic");
	}
	public void loadMenu() {
		Application.LoadLevel ("Menu");
	}
}
