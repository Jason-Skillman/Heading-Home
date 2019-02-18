using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkNearSoup : MonoBehaviour {

	public SoupRecipe soupRecipe;

	
	public void OnTriggerEnter2D(Collider2D collision) {
		if(collision.gameObject.CompareTag("Player")) {
			soupRecipe.Show();
		}
	}

	public void OnTriggerExit2D(Collider2D collision) {
		if(collision.gameObject.CompareTag("Player")) {
			soupRecipe.Hide();
		}
	}

}
