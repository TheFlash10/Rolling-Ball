using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public GameObject sphere;

	private Vector3 offset;

	void Start()
	{
		offset = transform.position - sphere.transform.position;
	}

	void LateUpdate ()
    {
		transform.position = sphere.transform.position + offset;
	}
}
