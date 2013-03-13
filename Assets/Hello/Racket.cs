using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour
{
	#region "define constants for Racket"
	public const float Accel = 1000.0f;
	#endregion

	// Use this for initialization
	void Start()
	{
	}
	
	// Update is called once per frame
	void Update()
	{
		rigidbody.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * Accel, ForceMode.Impulse);
	}
}
