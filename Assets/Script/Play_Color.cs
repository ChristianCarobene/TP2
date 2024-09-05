using System;
using UnityEngine;

public class Play_Color : MonoBehaviour
{
    [SerializeField] private GameObject tower;
    [SerializeField] private KeyCode keyColorRand = KeyCode.R;
    [SerializeField] private SpriteRenderer rendTower;
    [SerializeField] private SpriteRenderer rendCanon;

    private Color color;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(keyColorRand))
        {

            color = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
            rendCanon.color = color;
            rendTower.color = color;
        }
    }
}
