
using UnityEngine;

public class Play_Rotate : MonoBehaviour
{
    private Vector3 pos;
    private GameObject tower;
    [SerializeField] float rotation = 10f;
    [SerializeField] private KeyCode keyRotateRight = KeyCode.E;
    [SerializeField] private KeyCode keyRotateLeft = KeyCode.Q;
    private float rot;
    private void Awake()
    {
        tower = gameObject;
    }
    void Update()
    {
     
        if (Input.GetKeyDown(keyRotateRight))
        {
            rot = rotation * (-1);
            tower.transform.Rotate(0, 0, rot);
        }
        if (Input.GetKeyDown(keyRotateLeft))
        {
            tower.transform.Rotate(0, 0, rotation);
        }
    }
}
