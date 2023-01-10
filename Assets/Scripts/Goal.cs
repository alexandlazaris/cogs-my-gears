using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    LevelControl levelControl = null;
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

     void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.name == collidingGameObject.name)
        {
            Debug.Log(">>> GOAL!");
            Debug.Log(gameObject.name + " hit by " + collider.gameObject.name);
            levelControl.UpdateCurrentLevel();
        }
    }
}
