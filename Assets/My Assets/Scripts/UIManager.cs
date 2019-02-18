using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	//Singleton
	public static UIManager main;

	public Image imageItem;


	void Awake() {
		DontDestroyOnLoad(gameObject);

		//Singleton
		if(!main) main = this;
		else Destroy(gameObject);
	}

	void Update() {

	}

	public void AddItem(Sprite sprite) {
		imageItem.sprite = sprite;
		Color color = new Color(1, 1, 1, 1);
		imageItem.color = color;
	}

	public Sprite RemoveItem() {

		Color color = new Color(0, 0, 0, 0);
		imageItem.color = color;

		Sprite spriteRemoving = imageItem.sprite;
		imageItem.sprite = null;

		return spriteRemoving;
	}

	public Sprite GetSprite() {
		return imageItem.sprite;
	}

}
