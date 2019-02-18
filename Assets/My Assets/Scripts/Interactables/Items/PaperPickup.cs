using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperPickup : MonoBehaviour, IInteractable {

	public PaperManager paperManager;
	
	public void OnInteract(GameObject gameObject) {
		paperManager.AddPaper();
		Destroy(this.gameObject);
	}

}
