using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chef : NPC {
	
	public override void Update() {
		if(GameManager.main.flagHelpFood) {
			imageIcon.sprite = spriteHeart;
		}
	}

	public override void OnInteract(GameObject gameObject) {
		if(GameManager.main.flagHelpFood)
			dialogueComplete.TriggerDialogue();
		else {
			dialogueHelp.TriggerDialogue();
		}
	}

}
