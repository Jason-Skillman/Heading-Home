using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPickup : MonoBehaviour, IInteractable {
	
	public int bookID;


	public void Awake() {
	}

	public void OnInteract(GameObject gameObject) {
		BookManager.main.ShowBook(bookID);
	}
	
}
