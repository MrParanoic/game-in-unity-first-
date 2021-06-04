using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverSpawner : MonoBehaviour
{
    [SerializeField] private float speed;
    bool canMove;
    private float left = -2.40f;
    private float right = 2.40f;
    [SerializeField] private Transform blockPrefabMove;
   
    private void Update()
    {
        moverBox();
    }
    public void moverBox()
    {
        float temp = transform.position.x;


        if (temp < left)
        {
            blockPrefabMove.position += (Vector3.left * speed * Time.deltaTime);
        }
        else if (temp>right)
        {
            blockPrefabMove.position += (Vector3.left * speed * -1f * Time.deltaTime);
        }
        

    }
}
