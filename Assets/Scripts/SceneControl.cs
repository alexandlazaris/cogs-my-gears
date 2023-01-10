using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    [SerializeField]
    string sceneName = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadSceneByReference()
    {
        Debug.Log("sceneName to load: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
