using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBlocker : MonoBehaviour {
	
	void Update() {
		if(GameManager.main.flagHelpAnimal && GameManager.main.flagHelpFood && GameManager.main.flagHelpMusic) {
			gameObject.SetActive(false);
		}
	}

}
