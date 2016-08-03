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
	public float motionMagnitude = 0.1f;

	public bool doSpin = true;
	public bool doMotion = false;

	// Update is called once per frame
	void Update ()
	{

		if (doSpin) {
			//rotate around Y
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
		}

		if (doMotion) {
			//move up and down
			gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
	
		}
	}
}
