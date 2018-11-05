using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public static AudioClip Coin;
    

    static AudioSource audioSrc;

	// Use this for initialization
	void Start () {
        Coin = Resources.Load<AudioClip>("Coin");


        audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public  static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Coin":
                audioSrc.PlayOneShot (Coin);
                break;

            




        }

    }
}
