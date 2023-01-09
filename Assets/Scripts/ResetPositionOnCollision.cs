using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositionOnCollision : MonoBehaviour
{
    [SerializeField]
    Transform startingTransform = null;
    [SerializeField]
    GameObject collidingGameObject = null;
    [SerializeField]
    PlayerControl player = null;
    
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
            // collidingGameObject.transform.GetChild(0).GetComponent<Rigidbody>().velocity = Vector3.zero;
            // collidingGameObject.transform.GetChild(0).GetComponent<Rigidbody>().angularVelocity= Vector3.zero;
        }   
    }

    public void ResetPosition()
    {
        collidingGameObject.GetComponent<Transform>().position = startingTransform.position;
        collidingGameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        // player.WaitToStart();
        // player.PlayerHasDied();
    }

    // need to set gameobject player as the collider then pass it into this above function
    // maybe another function to find and set the object first

}
