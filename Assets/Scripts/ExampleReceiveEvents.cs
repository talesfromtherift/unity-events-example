using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleReceiveEvents : MonoBehaviour {

	public void OnSomethingHappened() {
		RandomizeMyColor ();
	}

	void RandomizeMyColor() {
		GetComponent<Renderer>().material.color = new Color (Random.value, Random.value, Random.value, 1.0f);
	}
}
