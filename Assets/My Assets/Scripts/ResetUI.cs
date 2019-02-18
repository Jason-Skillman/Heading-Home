using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetUI : MonoBehaviour {
	
	void Update() {
		UIManager.main.RemoveItem();
	}

}
