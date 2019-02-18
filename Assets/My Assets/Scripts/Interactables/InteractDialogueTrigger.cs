using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueManager;

public class InteractDialogueTrigger : MonoBehaviour, IInteractable {

	public bool isOn = true;

	public DialogueScript dialogue;


	public void OnInteract(GameObject gameObject) {
		if(isOn)
			dialogue.TriggerDialogue();
	}
	
}
