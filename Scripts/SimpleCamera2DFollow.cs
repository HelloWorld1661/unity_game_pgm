/*
 * RP
 * 10/18/17
 */

using System;
using UnityEngine;

// require / call for component - if not there, unity will create it
//[RequireComponent (typeof(SpriteRenderer))]

public class SimpleCamera2DFollow : MonoBehaviour
{
	public Transform target;

	void Update ()
	{
		Vector3 position = transform.position;
		position.x = target.transform.position.x + 5f;
		// RP 10/18/17 this sets a cam ceiling so it doesn't go past BG height
		if (target.position.y < 4 && target.position.y > 0) {
			position.y = target.transform.position.y;
		}
		transform.position = position;
	}
}