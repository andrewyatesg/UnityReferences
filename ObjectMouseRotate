/**
 * This script is used for rotating a GameObject using the mouse given
 * that it is restricted to rotate about a certain axis. For example,
 * a cylinder forced to "roll" based on the position of the mouse should
 * use this script. If you wish to rotate the GameObject in another way,
 * there are more efficient ways to do it.
**/


using UnityEngine;
using System.Collections;

public class ObjectMouseRotate : MonoBehaviour
{

	Rigidbody rigidbodyPlayer;

	void Start ()
	{
		rigidbodyPlayer = GetComponent<Rigidbody> ();
	}
	

	void Update ()
	{
		Turning ();
	}

	void Turning ()
	{
		Vector3 mousePos = Input.mousePosition; //The position of the mouse on the screen. (0,0) bottom-left and (WIDTH, HEIGHT) top-right corner
		Vector3 playerPos = Camera.main.WorldToScreenPoint (transform.position); //Get the player's position as screen coordinates (like above)
		Vector3 relative = mousePos - playerPos; //Get the mouse's position relative to the player's position

		float rot = Mathf.Rad2Deg * Mathf.Atan (relative.y / relative.x); //Find the polar angle of the mouse coords in degrees
		if (relative.x < 0)
			rot += 180; //Due to the nature of inverse tangent

		Quaternion quat = Quaternion.Euler (new Vector3 (rot, -90, -90)); //Convert rotation vector to Quaternion for rotation
		//(x, -90, -90) is the format for rotating the proper direction. **Specific to this example**

		rigidbodyPlayer.MoveRotation (quat);
	}
}
