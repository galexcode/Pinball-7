using UnityEngine;
using System.Collections;

public class RightFlipper : Flipper {
	protected override void Start() {
		base.Start();
		inputButtonName = "RightFlipper";	
		pressedPosition = 40f;
	}
}
