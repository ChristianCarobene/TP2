using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UiTank : MonoBehaviour
{
    [SerializeField] private GameObject Tank;
    [SerializeField] private Image imgTower;
    [SerializeField] private Image imgBody;
    [SerializeField] private Image imgCanon;
    [SerializeField] private Image imgTruck1;
    [SerializeField] private Image imgTruck2;
    [SerializeField] private string towerA, towerB, towerC;
    [SerializeField] private string bodyA, bodyB, bodyC;
    [SerializeField] private string canonA, canonB, canonC,canonD;
    [SerializeField] private string truckA, truckB, truckC, truckD;
    private string towerS, bodyS,canonS,truckS;

    public int typeBody = 1;
    public int typeCanon = 1;
    public int typeTower = 1;
    public int typeTrucks = 1;

    public void UpdateImg()
    {
        switch(typeBody)
        {
            case 1:
                bodyS = bodyA;
                break;
            case 2:
                bodyS = bodyB;
                break;
            case 3:
                bodyS = bodyC;
                break;
            default:
                bodyS = bodyA;  
                break;
        }
        switch(typeTower)
        {
            case 1:
                towerS = towerA;
                break;
            case 2:
                towerS = towerB;
                break;
            case 3:
                towerS = towerC;
                break;
            default :   
                towerS = towerA;
                break;
        }    
        switch(typeCanon)
        {
            case 1: 
                canonS = canonA;
                break;
            case 2:
                canonS = canonB;
                break;
            case 3:
                canonS = canonC;
                break;
            case 4:
                canonS = canonD;
                break;
            default:
                canonS = canonA;
                break;
        }
        switch(typeTrucks)
        {
            case 1: 
                truckS = truckA;
                break;
            case 2: 
                truckS = truckB;    
                break;
            case 3:
                truckS = truckC;
                break;
            case 4:
                truckS = truckD;
                break;
            default:
                truckS = truckA;
                break;
        }

        imgTower.sprite = Resources.Load<Sprite>(towerS);
        imgBody.sprite = Resources.Load<Sprite>(bodyS);
        imgCanon.sprite = Resources.Load<Sprite>(canonS);
        imgTruck1.sprite = Resources.Load<Sprite>(truckS);
        imgTruck2.sprite = Resources.Load<Sprite>(truckS);
    }
}
