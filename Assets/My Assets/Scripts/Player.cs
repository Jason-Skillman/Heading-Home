using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

	//Singleton
	public static Player main;

	public Vector2 movmentVectorRaw;
	public Vector2 movmentVector;
	public float speed = 5;
	public bool canMove = true;
	public Direction direction;
	public BoxCollider2D interactiveField;

	private Animator animator;
	private new Rigidbody2D rigidbody2D;

	private Vector2 interactiveNewOffset = new Vector2();

	public Collider2D collideri;

	void Awake() {
		DontDestroyOnLoad(gameObject);

		//Singleton
		if(!main) main = this;
		else Destroy(gameObject);

		animator = GetComponent<Animator>();
		rigidbody2D = GetComponent<Rigidbody2D>();
	}

	void Update() {

		//What direction are you facing
		if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
			direction = Direction.Up;
		} else if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) {
			direction = Direction.Down;
		} else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
			direction = Direction.Right;
		} else if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
			direction = Direction.Left;
		}

		if(canMove && !DialogueManager.DialogueManager.main.IsDialoguePlaying) {
			movmentVectorRaw = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
			movmentVector = movmentVectorRaw * speed;

			//Are you walking?
			if(movmentVectorRaw.x != 0 || movmentVectorRaw.y != 0) {
				animator.SetBool("isWalking", true);
			} else {
				animator.SetBool("isWalking", false);
			}
			
			//Set the new coords of the interactive field
			switch(direction) {
				case Direction.Up:
					interactiveNewOffset.x = 0f;
					interactiveNewOffset.y = 2.5f;
					break;
				case Direction.Down:
					interactiveNewOffset.x = 0f;
					interactiveNewOffset.y = -7.5f;
					break;
				case Direction.Right:
					interactiveNewOffset.x = 5f;
					interactiveNewOffset.y = -2.5f;
					break;
				case Direction.Left:
					interactiveNewOffset.x = -5f;
					interactiveNewOffset.y = -2.5f;
					break;
			}
			interactiveField.offset = interactiveNewOffset;

			//Add direction to blendmap animation
			if(movmentVectorRaw.x == 0 && movmentVectorRaw.y == 0) {
				
			} else {
				animator.SetFloat("input_x", movmentVectorRaw.x);
				animator.SetFloat("input_y", movmentVectorRaw.y);
			}

			//Interactive
			if(Input.GetKeyDown(KeyCode.Space)) {
				BoxCollider2D[] box2ds = GameObject.FindObjectsOfType<BoxCollider2D>();
				
				for(int i = 0; i < box2ds.Length; i++) {
					interactiveField.enabled = true;
					//Debug.Log(box2ds[i].gameObject.name);

					//if(interactiveField.OverlapPoint(box2ds[i].gameObject.transform.position)) {
					//if(box2ds[i].OverlapPoint(interactiveField.gameObject.transform.position)) {
					if(box2ds[i].IsTouching(interactiveField)) {

						//Debug.Log(box2ds[i].gameObject.name);
						//Debug.Log("Interation found!!!");

						//interactiveField.enabled = false;

						IInteractable interactable = box2ds[i].gameObject.GetComponent<IInteractable>();
						if(interactable != null) {
							interactable.OnInteract(gameObject);
						}
						//break;
					}
				}

			}
			if(Input.GetKeyUp(KeyCode.Space)) {
				//interactiveField.enabled = false;
			}


		} else {
			animator.SetBool("isWalking", false);
			movmentVectorRaw = Vector2.zero;
			movmentVector = Vector2.zero;
		}

	}

	private void FixedUpdate() {
		//rigidbody2D.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * speed, 0.8f), Mathf.Lerp(0, Input.GetAxis("Vertical") * speed, 0.8f));
		rigidbody2D.velocity = movmentVector;
	}

	void OnTriggerEnter2D(Collider2D collision) {
		//Debug.Log("Collision with something: " + collision.name);
	}
	
}

public enum Direction {
	Up,
	Down,
	Right,
	Left
}
