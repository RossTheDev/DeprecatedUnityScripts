using UnityEngine;
using UnityEngine.Events;

public class DeathController : MonoBehaviour
{
    public LayerMask groundLayer;
    internal KeyCode KeyCode;
    public float jumpForce;
    
    

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
       
        if (Input.GetKey(KeyCode.R))
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


    // charatcer left right movement 










}