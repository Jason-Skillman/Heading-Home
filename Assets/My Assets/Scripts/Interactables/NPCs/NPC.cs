using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueManager;

public class NPC : MonoBehaviour, IInteractable {
	
	public SpriteRenderer imageIcon;
	public Sprite spriteHeart;

	public DialogueScript dialogueHelp;
	public DialogueScript dialogueComplete;


	public virtual void Update() {
		
	}

	public virtual void OnInteract(GameObject gameObject) {
		
	}

}
