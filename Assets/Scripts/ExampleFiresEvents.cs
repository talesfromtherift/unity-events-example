using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExampleFiresEvents : MonoBehaviour {

	public UnityEvent onSomethingHappenedEvent;

	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
			onSomethingHappenedEvent.Invoke ();
		}
	}
}
