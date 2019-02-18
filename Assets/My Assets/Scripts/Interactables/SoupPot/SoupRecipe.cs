using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoupRecipe : MonoBehaviour {

	public SpriteRenderer slot1;
	public SpriteRenderer slot2;
	public SpriteRenderer slot3;
	public SpriteRenderer slot4;
	public SpriteRenderer slot5;

	public Sprite spriteIng1;
	public Sprite spriteIng2;
	public Sprite spriteIng3;
	public Sprite spriteIng4;
	public Sprite spriteIng5;

	private Animator animator;


	public void Awake() {
		animator = GetComponent<Animator>();
	}

	public void AddIngredient(Sprite sprite) {
		if(slot1.sprite != null && slot2.sprite != null && slot3.sprite != null && slot4.sprite != null && slot5.sprite != null) {
			ClearIngredients();
		}

		if(slot1.sprite == null) {
			slot1.sprite = sprite;
		} else if(slot2.sprite == null) {
			slot2.sprite = sprite;
		} else if(slot3.sprite == null) {
			slot3.sprite = sprite;
		} else if(slot4.sprite == null) {
			slot4.sprite = sprite;
		} else if(slot5.sprite == null) {
			slot5.sprite = sprite;

			if(slot1.sprite == spriteIng1 &&
				slot2.sprite == spriteIng2 &&
				slot3.sprite == spriteIng3 &&
				slot4.sprite == spriteIng4 &&
				slot5.sprite == spriteIng5) {

				GameManager.main.flagHelpFood = true;
			}
		}
	}

	public void ClearIngredients() {
		slot1.sprite = null;
		slot2.sprite = null;
		slot3.sprite = null;
		slot4.sprite = null;
		slot5.sprite = null;
	}

	public void Show() {
		animator.SetTrigger("Show");
	}

	public void Hide() {
		animator.SetTrigger("Hide");
	}

}
