using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTransform : MonoBehaviour
{
    [SerializeField]
    Transform followThis = null;
    
    [SerializeField]
    bool enableFollow = false;

    // Start is called before the first frame update
    void Start()
    {
        EnableFollowing();
    }

    // Update is called once per frame
    void Update()
    {
        // while(enableFollow)
        transform.position = new Vector3(followThis.position.x, followThis.position.y, -10);
    }

    public void DisableFollowing() {
        enableFollow = false;
    }

    public void EnableFollowing() {
        enableFollow = true;
    }
}
