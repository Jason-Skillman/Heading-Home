using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookManager : MonoBehaviour {

	//Singleton
	public static BookManager main;

	//Read only
	public bool isOpen = false;

	public Image UIBook;
	public GameObject[] books;


	void Awake() {
		DontDestroyOnLoad(gameObject);

		//Singleton
		if(!main) main = this;
		else Destroy(gameObject);
	}

	void Update() {
		//testing
		//if(Input.GetKeyDown(KeyCode.I)) {
		//	ShowBook(1);
		//}
		//if(Input.GetKeyDown(KeyCode.O)) {
		//	HideBook();
		//}

		if(Input.anyKeyDown && isOpen) {
			HideBook();
		}
	}

	public void ShowBook(int id) {
		isOpen = true;
		UIBook.enabled = true;

		foreach(GameObject book in books) {
			book.SetActive(false);
		}

		books[id - 1].SetActive(true);
	}

	public void HideBook() {
		isOpen = false;
		UIBook.enabled = false;

		foreach(GameObject book in books) {
			book.SetActive(false);
		}
	}

}
