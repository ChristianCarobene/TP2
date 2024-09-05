
using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Controles")]
    [SerializeField] private KeyCode keyUp = KeyCode.W;
    [SerializeField] private KeyCode keyDown = KeyCode.S;
    
    [Header("Variables Publicas")]
    public float speed = 0.01f;
    public bool isPause = false;
    private new Rigidbody2D rigidbody;
    private Vector3 pos;
    private Vector3 startPos;
    private Vector3 velocity;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        startPos = transform.position;        
    }

    void Update()
    {
        //ojo!!!!! si esta en pausa no hago el update
        if (isPause) return;
        //Move();
        
                     
      
    }
    private void FixedUpdate()
    {
        Move(); 
    }
    /*private void Move()
    {
        if (Input.GetKey(keyUp))
        {
           rigidbody.velocity=new Vector2(0, speed*Time.fixedDeltaTime);
           

        }

        if (Input.GetKey(keyDown))
        {
            //rigidbody.velocity = new Vector2(0, -speed * Time.fixedDeltaTime);
            rigidbody.AddForce(new Vector3(0, speed * -1, 0), ForceMode2D.Impulse);
            // rigidbody.AddForce(new Vector3(0, speed * -1, 0), ForceMode2D.Force);

        }
        if (Input.GetKeyUp(keyUp))
        {
            rigidbody.velocity = new Vector2(0, 0);


        }
        if (Input.GetKeyUp(keyDown))
        {
            //rigidbody.velocity = new Vector2(0, 0);
            rigidbody.AddForce(new Vector3(0, speed * -1, 0), ForceMode2D.Impulse);
            // rigidbody.AddForce(new Vector3(0, speed * -1, 0), ForceMode2D.Force);

        }
    }*/
    private void Move()
        {
            if (Input.GetKey(keyUp))
            {
               rigidbody.AddForce(new Vector2(0, speed), ForceMode2D.Impulse);
               //rigidbody.AddForce(new Vector3(0, speed, 0), ForceMode2D.Force);

            }
            if (Input.GetKey(keyDown))
            {
                rigidbody.AddForce(new Vector3(0, -speed, 0), ForceMode2D.Impulse);
                // rigidbody.AddForce(new Vector3(0, speed * -1, 0), ForceMode2D.Force);

            }
        }
    public void SetSpeed(float newSpeed)
    {
        if (newSpeed <= 1)
        {
            speed = newSpeed;
        }
    }
 

    public void Reset()
    { 
        rigidbody.velocity = Vector3.zero;
        transform.position = startPos; 
    }
}