using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositionOnCollision : MonoBehaviour
{
    [SerializeField]
    Transform startingTransform = null;

    [SerializeField]
    GameObject collidingGameObject = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collider) {
        Debug.Log(gameObject.name + " hit by " + collider.gameObject.name);
        if(collider.gameObject.name == collidingGameObject.name)
        {
            collidingGameObject.GetComponent<Transform>().position = startingTransform.position;
            // collidingGameObject.transform.GetChild(0).GetComponent<Rigidbody>().velocity = Vector3.zero;
            // collidingGameObject.transform.GetChild(0).GetComponent<Rigidbody>().angularVelocity= Vector3.zero;
        }
        
    }
}
