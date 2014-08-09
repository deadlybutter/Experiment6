using UnityEngine;
using System.Collections;

public class ScientistAI : MonoBehaviour {

	public float speedMin;
	public float speedMax;

	void Start () {

	}

	void FixedUpdate(){
		rigidbody.AddForce(new Vector3(Random.Range(-1, 2) * getSpeed(), 0, Random.Range(-1, 2) * getSpeed()));
	}

	float getSpeed(){
		return Random.Range(speedMin, speedMax);
	}

}