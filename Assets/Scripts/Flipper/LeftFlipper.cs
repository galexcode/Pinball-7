using UnityEngine;
using System.Collections;

public class LeftFlipper : Flipper {
	protected override void Start() {
		base.Start();
		inputButtonName = "LeftFlipper";	
		pressedPosition = -40f;
	}
}
