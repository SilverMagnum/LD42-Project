using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick: MonoBehaviour {
	public GameObject levelManager;

	private void Update() {
		if(Input.GetMouseButtonDown(0)) {
			levelManager.GetComponent<GeneratorCounter>().generatorCounter--;
			Object.Destroy(this);
		}
	}
}
