using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour {

	private Animator animator;
	public Animator animator2;


	void Awake() {
		animator = GetComponent<Animator>();
	}
	
	public void NotHiding() {
		animator.SetBool("isHidden", false);
	}

	public void NotWalking() {
		animator.SetBool("isWalking", false);
	}

	public void WalkAnimation() {
		animator2.SetTrigger("walk");
	}

}
