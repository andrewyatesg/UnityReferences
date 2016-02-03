using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour 
{
	public AudioClip ac; //Audio clip we can change to

	AudioSource audioSource; //AudioSource of the GameObject

	float time = 0;

	void Start () 
	{
		audioSource = GetComponent<AudioSource> (); //Initialize AudioSource component
		//We have PlayOnWake enabled, so audio will start when game starts
	}
	
	void Update () 
	{
		time += Time.deltaTime;

		if (time >= 10) //Replays the audio every 10 seconds
		{
			audioSource.Play ();
			//audioSource.Pause ();
			time = 0;
		}

		//We can also change the audio using:
		//audioSource.clip = ac;
	}
}
