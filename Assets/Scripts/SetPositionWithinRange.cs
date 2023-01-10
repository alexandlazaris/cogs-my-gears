using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPositionWithinRange : MonoBehaviour
{
    [SerializeField]
    int minX = 0;
    [SerializeField]
    int maxX = 0;
    [SerializeField]
    int minY = 0;
    [SerializeField]
    int maxY = 0;
    [SerializeField]
    Transform objectToReposition = null;

    // Start is called before the first frame update
    void Start()
    {
        randomisePosition();
    }

    void OnCollisionEnter(Collision collider) {
        if(collider.gameObject.name == "drop ball")
        {
            randomisePosition();
            // int randomX, randomY;
            // randomX = Random.Range(minX, maxX);
            // randomY = Random.Range(minY, maxY);
            // Debug.Log("x: " + randomX + ", y: " + randomY);
            // objectToReposition.localPosition = new Vector3(randomX, randomY, 0);
        }  
    } 

    public void randomisePosition()
    {       
        int randomX, randomY;
        randomX = Random.Range(minX, maxX);
        randomY = Random.Range(minY, maxY);
        Debug.Log("x: " + randomX + ", y: " + randomY);
        objectToReposition.localPosition = new Vector3(randomX, randomY, 0);
    }
}
