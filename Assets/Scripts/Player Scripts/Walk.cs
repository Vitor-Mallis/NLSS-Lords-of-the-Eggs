using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {

	[SerializeField]
	Animator animator;

	float speed = 4f;

	void Start () {
		animator = GetComponent<Animator> ();
	}

	void Update () {
		float horizontalAxis = Input.GetAxisRaw ("Horizontal");
		float verticalAxis = Input.GetAxisRaw ("Vertical");

		Vector3 tempPosition = transform.position;

		Vector2 tempScale = transform.localScale;

		if (horizontalAxis > 0) {
			tempPosition.x += speed * Time.deltaTime;
			animator.Play ("Running Right");
			tempScale.x = 0.33f;
		} else if (horizontalAxis < 0) {
			tempPosition.x -= speed * Time.deltaTime;
			animator.Play ("Running Right");
			tempScale.x = -0.33f;
		} else if (verticalAxis > 0) {
			tempPosition.y += speed * Time.deltaTime;
			animator.Play ("Running Up");
		} else if (verticalAxis < 0) {
			tempPosition.y -= speed * Time.deltaTime;
			animator.Play ("Running Down");
		}
		else if (horizontalAxis == 0 && verticalAxis == 0) {
			animator.Play ("Idle");
		}

		transform.position = tempPosition;
		transform.localScale = tempScale;
	}
}
