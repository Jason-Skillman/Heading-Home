using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoupPot : MonoBehaviour, IInteractable {

	public SoupRecipe soupRecipe;


	public void OnInteract(GameObject gameObject) {
		if(UIManager.main.GetSprite() != null) {
			//Debug.Log("Soup");
			soupRecipe.AddIngredient(UIManager.main.RemoveItem());
		}
	}

}
