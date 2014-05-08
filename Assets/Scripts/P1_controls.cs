﻿using UnityEngine;
using System.Collections;

public class P1_controls : MonoBehaviour {
	MovementAnimationScript mover;
	// Use this for initialization
	void Start () {
		mover = gameObject.GetComponent<MovementAnimationScript>();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetAxis("P1 - Dash") > 0) && (mover.stateBools["idling"])) {
			Debug.Log ("Dashing should happen by " + gameObject + " now!");
			mover.Dash ();
		}
		else if ((Input.GetAxis("P1 - Block") > 0)  && (mover.stateBools["idling"])) {
			mover.Block ();
		}
		else if ((Input.GetAxis("P1 - Punch") > 0) && (mover.stateBools["idling"])) {
			mover.Punch ();
		}
		else if ((Input.GetAxis("P1 - Special") > 0) && (mover.stateBools["idling"])) {
			mover.Special();
		}
		else {
			if (!mover.stateBools["animating"]){
				mover.fighterAnimation.CrossFade ("Idle");
			}
		}
	}
}
