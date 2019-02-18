using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperManager : MonoBehaviour {

	//Singleton
	//public static PaperManager main;

	public bool isOpen = false;
	//public bool noMorePaper = true;
	public GameObject UI;
	public int paperCount = 0;
	public Sprite spritePaper1;
	public Sprite spritePaper2;
	public Sprite spritePaper3;
	public Sprite spritePaper4;


	void Awake() {
		//DontDestroyOnLoad(gameObject);
		//
		////Singleton
		//if(!main) main = this;
		//else Destroy(gameObject);
	}

	void Update() {
		if(paperCount == 1)
			UIManager.main.AddItem(spritePaper1);
		if(paperCount == 2)
			UIManager.main.AddItem(spritePaper2);
		if(paperCount == 3)
			UIManager.main.AddItem(spritePaper3);
		if(paperCount == 4)
			UIManager.main.AddItem(spritePaper4);

		if(isOpen && Input.anyKeyDown) {
			isOpen = false;
			UI.SetActive(false);
		}

		if(paperCount == 4 && Input.GetKeyDown(KeyCode.I)) {
			isOpen = true;
			UI.SetActive(true);
		}
	}
	
	public void AddPaper() {
		paperCount++;
	}

}
