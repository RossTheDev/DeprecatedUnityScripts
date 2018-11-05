using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            //AudioListener.pause = !AudioListener.pause;
            Destroy(gameObject);

        }

    }
}


 