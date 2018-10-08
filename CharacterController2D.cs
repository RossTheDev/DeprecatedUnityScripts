using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
    public LayerMask groundLayer;
    internal KeyCode KeyCode;
    private float speed;
    public float jumpForce;
    private void Start()
    {
        speed = 8;
        GetComponent<SpriteRenderer>().flipX = true; //for simple animation, comment out if not animated 
    }

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;
        Debug.DrawRay(position, direction, Color.green);
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }

    void Update()
    {
      
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            GetComponent<SpriteRenderer>().flipX = true; //false if not animated
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            GetComponent<SpriteRenderer>().flipX = false; //true if not animated
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (!IsGrounded())
            {

            }
            else
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    }


}