// RP see <https://www.youtube.com/watch?v=7KiK0Aqtmzc>
using System.Collections;
using UnityEngine;

public class JumpBetter : MonoBehaviour {

	[Range(1,10)]
	public float fallMultiplier;
	[Range(1,10)]
	public float lowJumpMultiplier;

	Rigidbody2D rb;

	void Awake() {
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update() {
		if (rb.velocity.y < 0) {
			rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime; // subtracting 1 to account for initial jump
		} else if (rb.velocity.y > 0 && !Input.GetButton ("Jump")) {
			rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
		}
	}
}