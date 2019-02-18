using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueManager;

public class CrabStopWalking : MonoBehaviour {

	public Crab crab;
	public DialogueScript dialogueScript;


	public void StopWalking() {
		crab.NotWalking();
		dialogueScript.TriggerDialogue();
		GameManager.main.flagHelpAnimal = true;
	}

}
