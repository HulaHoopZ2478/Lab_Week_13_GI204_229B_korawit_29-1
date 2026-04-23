using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float Speed;
    float move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb2d.linearVelocity = new Vector2(move * Speed, rb2d.linearVelocity.y);
    }
}
