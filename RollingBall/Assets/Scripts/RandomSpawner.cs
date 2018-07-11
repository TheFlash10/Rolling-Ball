using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {

	private float nextActionTime = 0.0f;
	public float period = 2f;
	public GameObject spawnees;

	int randomInt;

	// Update is called once per frame
	void Update()
	{
		if (Time.time > nextActionTime)
		{
			nextActionTime += period;
			Vector3 position = new Vector3(Random.Range(-2.5f, 2.5f), 5f , Random.Range(-2f, 2f));
			Instantiate(spawnees, position , Quaternion.identity);
	}
}
	}
