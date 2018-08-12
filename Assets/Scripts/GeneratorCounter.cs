using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorCounter: MonoBehaviour {
	public int generatorCounter	= 4;

	private int counterVerify	= 4;

	private void Update () {
		if(generatorCounter < counterVerify) {
			Debug.Log("Generator destroyed. Generator Count: " + generatorCounter + ".");
			counterVerify--;
		}
	}
}
