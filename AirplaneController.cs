using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class AirplaneController : MonoBehaviour {

	public HandController handCtrl;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = handCtrl.GetFrame();
		Hand hand = frame.Hands.Frontmost;
		if(hand.IsValid) {
//			print (hand.PalmPosition.ToUnityScaled());
			transform.position = new Vector3(hand.PalmPosition.x, hand.PalmPosition.y, 0);
			transform.rotation = 
				handCtrl.transform.rotation * hand.Basis.Rotation(false);
		}

	}
}

