using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private int _startingForce = 3000;
	private Vector3 _velocity;
	
	// Use this for initialization
	void Start () {
		rigidbody.AddRelativeForce(Vector3.forward * _startingForce);
	//	_velocity = rigidbody.velocity;
	}
	
	/*
	void FixedUpdated() {
		_velocity.y = 0;	//Strictly horizontal
		transform.Translate(_velocity * Time.deltaTime, Space.World);
	}
	
	void OnCollisionEnter(Collision coll) {
		Debug.Log ("BAM");
		_velocity = rigidbody.velocity;
		
		var hit = coll.contacts[0];
		var normal = hit.normal;
		normal.y = 0;
		
		Debug.DrawRay (hit.point, hit.normal, Color.green, 10.3f);
		Debug.DrawRay (hit.point, -_velocity, Color.red, 10.3f);
		Debug.Log ("Velocity: " + _velocity);
		_velocity = Vector3.Reflect (_velocity * 1000, hit.normal);
		Debug.DrawRay (hit.point, _velocity, Color.blue, 10.3f);
	}
	
	/*
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionExit(Collision collision) {
		Bounce bounce = collision.gameObject.GetComponent<Bounce>();
		Debug.Log ("Collision");
		if (bounce != null) {
			float magnitude = bounce.magnitude; //GetMagnitude();
			Debug.Log (magnitude);
			BounceBack(magnitude);
		}
	}
	
	void BounceBack(float magnitude) {
		rigidbody.AddForce(Vector3.forward * magnitude);
	}
	*/
}
