using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueManager;

public class ToneManager : MonoBehaviour {
	
	public Sprite[] answer;
	public Sprite[] currentTry;
	public DialogueScript dialogueScript;

	bool flag = false;
	public void AddTone(Sprite spriteTone) {
		bool flagAnswer = true;
		bool flagPlaced = true;



		for(int i = 0; i < currentTry.Length; i++) {

			//Full?
			//if(currentTry[5] != null) {
			//	//Debug.Log("Full");
			//	for(int x = 0; x < currentTry.Length; x++) {
			//		currentTry[x] = null;
			//	}
			//}

			//if(currentTry[i] == null & flagPlaced) {
			//	flagPlaced = false;
			//	currentTry[i] = spriteTone;
			//}
			//
			//if(currentTry[i] != answer[i]) {
			//	flagAnswer = false;
			//}

			//flagAnswer = false;

			if(currentTry[i] == null) {
				if(spriteTone == answer[i]) {
					currentTry[i] = spriteTone;
					Debug.Log("Correct");

					//If full
					if(currentTry[5] != null) {
						flagAnswer = true;
					} else {
						flagAnswer = false;
					}

				} else {
					Debug.Log("Wrong");
					//Clear
					for(int x = 0; x < currentTry.Length; x++) {
						currentTry[x] = null;
					}
					flagAnswer = false;
				}

					

				//for(int y = 0; y < currentTry.Length; y++) {
				//	if(currentTry[i] != answer[i]) {
				//		flagAnswer = false;
				//	}
				//}

				break;
			}
			//Debug.Log(i);
			
			
			
		}

		if(flagAnswer) {
			GameManager.main.flagHelpMusic = true;
			dialogueScript.TriggerDialogue();
		}

	}
	
}
