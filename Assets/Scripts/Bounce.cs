using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {
	public float magnitude;
	
	#region Getters and Setters
	public float Magnitude {
		get {return magnitude;}
		set {magnitude = value;}
	}
	#endregion
	
	void OnCollisionEnter(Collision _other) {
		_other.rigidbody.AddExplosionForce(magnitude, this.transform.position, 5);		
	}
}