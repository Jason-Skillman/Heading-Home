using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueManager;

public class TriggerDialogue : MonoBehaviour {

	public bool isOn = true;
	public Player player;
	public DialogueScript dialogue;
	public string sceneName;


	public void OnTriggerEnter2D(Collider2D collision) {
		if(isOn && collision.gameObject.CompareTag("Player")) {
			player.canMove = false;
			dialogue.TriggerDialogue(OnEndCutScene);
		}
	}

	public void OnEndCutScene() {
		SceneFaderManager.main.FadeToScene(sceneName);
	}
	
}
