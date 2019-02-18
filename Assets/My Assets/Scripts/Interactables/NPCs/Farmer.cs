using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : NPC {

	public override void Update() {
		if(GameManager.main.flagHelpAnimal) {
			imageIcon.sprite = spriteHeart;
		}
	}

	public override void OnInteract(GameObject gameObject) {
		if(GameManager.main.flagHelpAnimal)
			dialogueComplete.TriggerDialogue();
		else {
			dialogueHelp.TriggerDialogue();
		}
	}

}
