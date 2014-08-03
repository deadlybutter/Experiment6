using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	public float speed;
	public float jumpForce;
	public float maxSpeed;

	public float mouseSensitivity;
	public float verticalRotation = 0;
	public float upDownRange;
	
	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		//Mouse rotation
		float yaw = Input.GetAxis("Mouse X") * mouseSensitivity;
		transform.Rotate(0, yaw, 0);
		
		verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
		verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
		Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);	
	}

	void FixedUpdate(){
		//Movement
		if(Input.GetKey(KeyCode.W)){
			rigidbody.AddForce(Vector3.ClampMagnitude(transform.forward * speed, maxSpeed));
		}
		if(Input.GetKey(KeyCode.S)){
			rigidbody.AddForce(Vector3.ClampMagnitude(-transform.forward * speed, maxSpeed));
		}
		if(Input.GetKey(KeyCode.A)){
			rigidbody.AddForce(Vector3.ClampMagnitude(-transform.right * speed, maxSpeed));
		}	
		if(Input.GetKey(KeyCode.D)){
			rigidbody.AddForce(Vector3.ClampMagnitude(transform.right * speed, maxSpeed));
		}

		//Jump
		if(Input.GetKey(KeyCode.Space)){
			if(isGrounded()){
				rigidbody.AddForce(transform.up * jumpForce);
			}
		}
	}

	bool isGrounded(){
		return Physics.Raycast(transform.position, -Vector3.up, 1);
	}

}
