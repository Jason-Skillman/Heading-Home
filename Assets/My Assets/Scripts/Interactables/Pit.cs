using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour, IInteractable {

	public Crab crab;
	public InteractDialogueTrigger dialogueTrigger;
	public Sprite spriteNeeded;
	public SpriteRenderer spriteRenderer;

	public void OnInteract(GameObject gameObject) {
		if(UIManager.main.GetSprite() == spriteNeeded) {
			spriteRenderer.sprite = UIManager.main.RemoveItem();
			crab.NotHiding();
			crab.WalkAnimation();
			dialogueTrigger.isOn = false;
		}
	}
	
}
