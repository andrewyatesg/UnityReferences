using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

	public float speed = 5f;

	float width;
	float height;
	
	Rigidbody rigidbodyPlayer;
	
	void Start ()
	{
		rigidbodyPlayer = GetComponent<Rigidbody> ();
	}
	
	
	void FixedUpdate ()
	{
		SetWindowDimensions ();

		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		Move (h, v);
	}

	void Move (float h, float v)
	{
		Vector3 movement = new Vector3 (h, v, 0).normalized * speed * Time.deltaTime;
		rigidbodyPlayer.MovePosition (rigidbodyPlayer.position + movement);

		Vector3 pos = rigidbodyPlayer.position;

		if (pos.x <= -width)
			pos.x = -width;

		if (pos.x >= width)
			pos.x = width;

		if (pos.y <= -height)
			pos.y = -height;

		if (pos.y >= height)
			pos.y = height;

		rigidbodyPlayer.MovePosition (pos);
	}

	void SetWindowDimensions ()
	{
		height = Camera.main.orthographicSize;
		width = height * Camera.main.aspect;
	}
}
