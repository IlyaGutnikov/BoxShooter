using UnityEngine;
using System.Collections;

/// <summary>
/// Basic mover.
/// </summary>
public class BasicMover : MonoBehaviour {

	/// <summary>
	/// The spin speed.
	/// </summary>
	public float spinSpeed = 180.0f;

	// Update is called once per frame
	void Update () {
	
		gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);

	}
}
