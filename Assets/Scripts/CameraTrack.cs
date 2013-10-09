using UnityEngine;
using System.Collections;

public class CameraTrack : MonoBehaviour {
	public GameObject track;
	public Vector3 displace;
	
	// Use this for initialization
	void Start () {
		displace = new Vector3(0,50,0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = track.transform.position + displace;
	}
}
