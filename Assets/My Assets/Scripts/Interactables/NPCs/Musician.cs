using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musician : NPC {

	public override void Update() {
		if(GameManager.main.flagHelpMusic) {
			imageIcon.sprite = spriteHeart;
		}
	}

	public override void OnInteract(GameObject gameObject) {
		if(GameManager.main.flagHelpMusic)
			dialogueComplete.TriggerDialogue();
		else {
			dialogueHelp.TriggerDialogue();
		}
	}

}
