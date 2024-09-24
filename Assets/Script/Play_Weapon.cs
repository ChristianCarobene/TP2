using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Weapon : MonoBehaviour
{
    [Header("Variables Publicas")]
    [SerializeField] private SpriteRenderer rendWeapon;
    [SerializeField] private Sprite weapon1, weapon2, weapon3;
    public float speed = 0.01f;
    public float torque = 0.01f;
    public int numberWeapon = 0;
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
        KickOff();
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
            x = 1;
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
        rigidbody.AddTorque(torque);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log(collision.transform.name);

    }

    public int getTypeWeapon()
    {
        return numberWeapon;
    }
    public void setTypeWeapon(int num)
    {
        numberWeapon=num;
    }
    public void SetSkinWeapon()
    {
        switch (numberWeapon)
        {
            case 1:
                rendWeapon.sprite = weapon1;
                break;
            case 2:
                rendWeapon.sprite = weapon2;
                break;
            case 3:
                rendWeapon.sprite = weapon3;
                break;
            default:
                rendWeapon.sprite = weapon1;
                break;
        }
    }
}
