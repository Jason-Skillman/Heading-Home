using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigger : MonoBehaviour {

	public GameObject gb;
	

	public void DesroyTrigger() {
		Destroy(gb);
	}

}
