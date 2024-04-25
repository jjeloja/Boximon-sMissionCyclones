using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHover : MonoBehaviour {
    public bool rotate; // rotate?
	public float rotationSpeed;
	public float hoverSpeed;
	public float hoverDistance;

	Vector3 cubePos = new Vector3();

    void Start()
    {
        cubePos = transform.position;
    }

	// called once per frame
	void Update () {
        float y = Mathf.PingPong(Time.time * hoverSpeed, hoverDistance) + 2;
        cubePos = new Vector3(0, y, 0);

		if (rotate)
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
	}
}
