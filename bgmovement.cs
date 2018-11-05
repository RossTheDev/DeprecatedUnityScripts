using UnityEngine;
using UnityEngine.Events;

public class bgmovement : MonoBehaviour
{
    internal KeyCode KeyCode;
    private float speed;


    private void Start()
    {
        speed = 8;

    }




    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
          }
    }

}

