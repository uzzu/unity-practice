using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
	#region "Define constants for Ball"
	public const float Speed = 10.0f;
	#endregion

	// Use this for initialization
	void Start()
	{
		rigidbody.AddForce((transform.forward + transform.right) * Speed, ForceMode.VelocityChange);
	}

	// Update is called once per frame
	void Update()
	{
	}
}
