using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ExitScript : MonoBehaviour
{
    [SerializeField] private string newLevel;

    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(newLevel);

        }
    }
}