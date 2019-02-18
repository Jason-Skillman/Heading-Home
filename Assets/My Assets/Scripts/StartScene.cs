using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueManager;

public class StartScene : MonoBehaviour {
	
	public Player player;
	public DialogueScript dialogueScript;


	void Start() {
		if(GameManager.main.flagPlayedIntro) {
			GameManager.main.flagPlayedIntro = false;
			TriggerStart();
		}
	}
	
	void TriggerStart() {
		player.canMove = false;
		dialogueScript.TriggerDialogue(TriggerEnd);
	}

	void TriggerEnd() {
		player.canMove = true;
	}

}
