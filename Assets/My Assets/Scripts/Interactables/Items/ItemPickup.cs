using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour, IInteractable {

	public SpriteRenderer image;
	public Sprite sprite;


	public void Awake() {
		image.sprite = sprite;
	}

	public void OnInteract(GameObject gameObject) {
		UIManager.main.AddItem(sprite);
	}
	
}
