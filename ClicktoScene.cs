using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ClicktoScene : MonoBehaviour
{
    [SerializeField] private string newLevel;


    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {

            SceneManager.LoadScene(newLevel);

        }

    }
}
