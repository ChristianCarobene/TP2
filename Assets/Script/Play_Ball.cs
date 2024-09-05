
using UnityEngine;

public class Play_Ball : MonoBehaviour
{
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
    
    public void KickOff()
    {
        float x; 
        float y;
        Debug.Log("Toy en KickOff de Ball");

        if (Random.Range(0, 2) == 0)
        {
            x = -1;
        }
        else
        {
            x= 1;
        }


        if (Random.Range(0, 2) == 0)
        {
            y = -1;
        }
        else
        {
            y = 1;
        }
        
        rigidbody.velocity = new Vector3(x * speed, y * speed, 0);
        Debug.Log("X: " + x + "Y: " + y + "V: " + rigidbody.velocity);
    }
    public void AddForce(float velocity)
    {
        rigidbody.AddForce(new Vector3(0, speed * -1, 0), ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.name);
     
    }
}

