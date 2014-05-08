﻿using UnityEngine;
using System.Collections;

public class P2_controls : MonoBehaviour {
	MovementAnimationScript mover;
	// Use this for initialization
	void Start () {
		mover = gameObject.GetComponent<MovementAnimationScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetAxis("P2 - Dash") > 0) && (mover.stateBools["idling"])) {
			mover.Dash ();
		}
		else if ((Input.GetAxis("P2 - Block") > 0)  && (mover.stateBools["idling"])) {
			mover.Block ();
		}
		else if ((Input.GetAxis("P2 - Punch") > 0) && (mover.stateBools["idling"])) {
			mover.Punch ();
		}
		else if ((Input.GetAxis("P2 - Special") > 0) && (mover.stateBools["idling"])) {
			mover.Special();
		}
		else {
			if (!mover.stateBools["animating"]){
				mover.fighterAnimation.CrossFade ("Idle");
			}
		}
	}
}
