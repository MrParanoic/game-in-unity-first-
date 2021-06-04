using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnClick : MonoBehaviour
{
    [SerializeField] private GameObject flootPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float _UpPower;
    [SerializeField] private Transform cam;
    int _upScore;
    bool prefabIsSpawned;
    public int score=0;
    public GameObject textScore;
    private void OnMouseDown()
    {
        Instantiate(flootPrefab, spawnPoint.position, Quaternion.identity);

        if (Input.GetKey(KeyCode.Mouse0))
        {
            _upScore++;
            if (_upScore%2==0)
            {
                cam.position += (Vector3.up * _UpPower);
                spawnPoint.position += (Vector3.up * _UpPower);
            }
        }
        score++;
        textScore.GetComponent<Text>().text = "height: " + score;  
    }
        
    
}
