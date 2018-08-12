using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDegreeMovement: MonoBehaviour {
	public float speed = 10.0f;

	private float vertical;
	private float horizontal;

    void Update() {
        vertical	= Input.GetAxis("Vertical") * speed * Time.deltaTime;
        horizontal	= Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		
        transform.Translate(horizontal, vertical, 0f);
    }
}
