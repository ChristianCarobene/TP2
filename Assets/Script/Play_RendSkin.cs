using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_RendSkin : MonoBehaviour
{
    [SerializeField] private SpriteRenderer rendTower;
    [SerializeField] private SpriteRenderer rendCanon;
    [SerializeField] private SpriteRenderer rendBody;
    [SerializeField] private SpriteRenderer rendTrucks1;
    [SerializeField] private SpriteRenderer rendTrucks2;
    [SerializeField] private GameObject tower;
    [SerializeField] private Sprite towerA, towerB, towerC;
    [SerializeField] private Sprite canonA, canonB, canonC, canonD;
    [SerializeField] private Sprite bodyA, bodyB, bodyC;
    [SerializeField] private Sprite trucksA, trucksB, trucksC, trucksD;
    public int typeBody = 1;
    public int typeCanon = 1;
    public int typeTower = 1;
    public int typeTrucks = 1;

    public void SetSkinTower()
    {
        switch (typeTower)
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
    }
    public void SetSkinCanon()
    {
        switch (typeCanon)
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
    }
    public void SetSkinBody()
    {
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
    }
    public void SetSkinTrucks()
    {
        switch (typeTrucks)
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
