using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTone : MonoBehaviour, IInteractable {

	public Sprite spriteNote;
	public GameObject anim;
	public ToneManager toneManager;


	public void OnInteract(GameObject gameObject) {
		GameObject obj = Instantiate(anim);
		obj.transform.position = transform.position;

		toneManager.AddTone(spriteNote);
	}

}
