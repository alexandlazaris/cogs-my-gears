using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolllowTransform : MonoBehaviour
{
    [SerializeField]
    Transform followThis = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, followThis.position.y, -10);
    }
}
