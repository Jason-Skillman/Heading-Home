using UnityEngine;

public class WarpPadIn : MonoBehaviour {

	public string sceneName;
	public int warpID = 1;
	
	private Player player;


	void OnTriggerEnter2D(Collider2D collision) {
		if(collision.gameObject.CompareTag("Player")) {
			player = collision.gameObject.GetComponent<Player>();
			player.canMove = false;
			player.movmentVector = Vector2.zero;
			
			WarpManager.main.WarpToLevel(player, sceneName, warpID);
		}
	}

	private void OnDrawGizmos() {
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(transform.position, new Vector3(1f, 1f, 0));
	}

}
