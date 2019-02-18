using UnityEngine;

public class WarpPadOut : MonoBehaviour {

	public int warpID = 1;
	public Direction direction = Direction.Down;


	public void OnWarpOut(Player player, string previousSceneName) {
		//player.SetDirection(direction);
		player.canMove = true;
	}

	private void OnDrawGizmos() {
		Gizmos.color = Color.blue;
		Gizmos.DrawWireCube(transform.position, new Vector3(1f, 1f, 0));
	}


}
