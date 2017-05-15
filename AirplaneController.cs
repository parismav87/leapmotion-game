using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class AirplaneController : MonoBehaviour {

	public HandController handCtrl;
	// Use this for initialization
	private Vector3 constantVelocity = new Vector3(0,0,100);
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update (){
		
		Frame frame = handCtrl.GetFrame();
		Hand hand = frame.Hands.Frontmost;
		if(hand.IsValid) {
			transform.position = new Vector3(hand.PalmPosition.x, hand.PalmPosition.y, transform.position.z); //z should be 0
			transform.position += constantVelocity * Time.deltaTime;
			transform.rotation = 
				handCtrl.transform.rotation * hand.Basis.Rotation(false);
		}
	}
}

