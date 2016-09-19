using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
//		Vector3 rot = gameObject.transform.rotation.eulerAngles;
//		float newAngle = rot.x + 0.0000001f;
//		if (newAngle > 360.0f) newAngle -= 360.0f;
//		if (newAngle < -360.0f)	newAngle += 360.0f;
//		gameObject.transform.Rotate (rot.x + 1f, 0.0f, 0.0f);
		gameObject.transform.Rotate (0.1f, 0.0f, 0.0f);
	}
}
