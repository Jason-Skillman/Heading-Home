using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueManager;

public class Honey : MonoBehaviour, IInteractable {

	public Sprite sprite;
	public DialogueScript dialogue;


	public void OnInteract(GameObject gameObject) {
		UIManager.main.AddItem(sprite);
		dialogue.TriggerDialogue();
		Destroy(this.gameObject);
	}

}
