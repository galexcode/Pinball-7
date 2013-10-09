using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour {
	public float mass = 2f;
	
	public float restPosition = 0f;
	public float pressedPosition = 45f;
	public float strength = 10000f;
	public float damper = 5f;
	public string inputButtonName = "LeftFlipper";
	
	private JointLimits _jointLimits;
	
	protected virtual void Start () {
		rigidbody.mass = mass;
		hingeJoint.useSpring = true;
		hingeJoint.useLimits = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		JointSpring spring = new JointSpring();
		spring.spring = strength;
		spring.damper = damper;
		
		if (Input.GetButton(inputButtonName)) {
			Debug.Log(inputButtonName + " Pressed");
			spring.targetPosition = pressedPosition;
		} else {
			spring.targetPosition = restPosition;
		}
		hingeJoint.spring = spring;
		
		_jointLimits = hingeJoint.limits;
		_jointLimits.min = restPosition;
		_jointLimits.max = pressedPosition;
		_jointLimits.minBounce = 0.02f;
		_jointLimits.maxBounce = 0.02f;
	}
}
