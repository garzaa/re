﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour {

	//launches the player in this direction on hit
	public Vector2 launchVector;

	Animator anim;

	void Start() {
		anim = GetComponent<Animator>();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "corpse") {
			other.gameObject.GetComponent<Rigidbody2D>().velocity = launchVector;
			anim.SetTrigger("jump");
		}
	}
}
