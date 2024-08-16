
using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.01f;
    public bool isPause = false;
    [SerializeField] float rotation = 10f;
    private float rot;
    private Vector3 pos;
    [SerializeField] private KeyCode keyUp = KeyCode.W;
    [SerializeField] private KeyCode keyDown = KeyCode.S;
    [SerializeField] private KeyCode keyLeft = KeyCode.A;
    [SerializeField] private KeyCode keyRight = KeyCode.D;
    [SerializeField] private KeyCode keyRotateRight = KeyCode.E;
    [SerializeField] private KeyCode keyRotateLeft = KeyCode.Q;
    [SerializeField] private KeyCode keyColorRand = KeyCode.R;
    [SerializeField] private SpriteRenderer rendTower;
    [SerializeField] private SpriteRenderer rendCanon;
    [SerializeField] private SpriteRenderer rendBody;
    [SerializeField] private SpriteRenderer rendTrucks1;
    [SerializeField] private SpriteRenderer rendTrucks2;
    [SerializeField] private GameObject tower;
    [SerializeField] private Sprite towerA, towerB, towerC;
    [SerializeField] private Sprite canonA, canonB, canonC,canonD;
    [SerializeField] private Sprite bodyA, bodyB, bodyC;
    [SerializeField] private Sprite trucksA, trucksB, trucksC, trucksD;
    public int typeBody = 1;
    public int typeCanon = 1;
    public int typeTower = 1;
    public int typeTrucks = 1;


    private Color color;



    void Update()
    {
        //ojo!!!!! si esta en pausa no hago el update
        if (isPause) return;

        pos = transform.position;

        if (Input.GetKey(keyUp))
        {
            pos.y += speed;
        }

        if (Input.GetKey(keyLeft))
        {
            pos.x -= speed;
        }

        if (Input.GetKey(keyDown))
        {
            pos.y -= speed;
        }

        if (Input.GetKey(keyRight))
        {
            pos.x += speed;
        }
        if (Input.GetKeyDown(keyRotateRight))
        {
            rot = rotation * (-1);
            tower.transform.Rotate(0, 0, rot);
        }
        if (Input.GetKeyDown(keyRotateLeft))
        {
            tower.transform.Rotate(0, 0, rotation);
        }
        if (Input.GetKeyUp(keyColorRand))
        {
            
            color = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
            rendCanon.color = color;
            rendTower.color = color;
        }
        transform.position = pos;

    }
    public void UpdateSpeed(float newSpeed)
    {
        if (newSpeed <= 1)
        {
            speed = newSpeed;
        }
        switch(typeTower)
        {
            case 1:
                rendTower.sprite = towerA;
                break;
            case 2:
                rendTower.sprite = towerB;
                break;
            case 3:
                rendTower.sprite = towerC;
                break;
            default:
                rendTower.sprite = towerA;
                break;
        }
        switch(typeCanon)
        {
            case 1:
                rendCanon.sprite = canonA;
                break;
            case 2:
                rendCanon.sprite = canonB;
                break;
            case 3:
                rendCanon.sprite = canonC;
                break;
            case 4:
                rendCanon.sprite = canonD;
                break;
            default:
                rendCanon.sprite = canonA;
                break;
            }
        switch (typeBody)
        {
            case 1:
                rendBody.sprite = bodyA;
                break;
            case 2:
                rendBody.sprite = bodyB;
                break;
            case 3:
                rendBody.sprite = bodyC;
                break;
            default:
                rendBody.sprite = bodyA;
                break;

        }
        switch(typeTrucks)
        {
            case 1:
                rendTrucks1.sprite = trucksA;
                rendTrucks2.sprite = trucksA;
                break;
            case 2:
                rendTrucks1.sprite = trucksB;
                rendTrucks2.sprite = trucksB;
                break;
            case 3:
                rendTrucks1.sprite = trucksC;
                rendTrucks2.sprite = trucksC;
                break;
            case 4:
                rendTrucks1.sprite = trucksD;
                rendTrucks2.sprite = trucksD;
                break;
            default:
                rendTrucks1.sprite = trucksA;
                rendTrucks2.sprite = trucksA;
                break;

        }
    }
}