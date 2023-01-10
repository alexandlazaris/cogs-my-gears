using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControl : MonoBehaviour
{    
    [SerializeField]
    LevelGroups [] levelGroups;
    [SerializeField]
    int currentLevelIdentifier = 0;
    [SerializeField]
    int startingLevelIdentifier = 0;
    [SerializeField]
    GameObject gameObjectParent = null;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateAllLevelObjects();
        SetStartingLevel();
        LevelChecker();
    }

    public void DeactivateAllLevelObjects()
    {
        foreach (LevelGroups objects in levelGroups)
        {
            objects.levelObjectParent.SetActive(false);
        }
    }

    void SetStartingLevel()
    {
        currentLevelIdentifier = startingLevelIdentifier;
    }

    public void activateObjectsBasedOnFlags()
    {
        foreach (LevelGroups objects in levelGroups)
        {
            if(objects.activate)
            {
                objects.levelObjectParent.SetActive(true);
            }
            else if(!objects.activate)
            {
                objects.levelObjectParent.SetActive(false);
            }
        }
    }

    void Awake()
    { 
        gameObjectParent.SetActive(false);                                                          
    }

    public void ToggleGameObjectActiveState(GameObject x, bool state)
    {
        x.SetActive(state);
    }

    public void SetLevelAsActive()
    {
        ToggleGameObjectActiveState(levelGroups[currentLevelIdentifier-1].levelObjectParent, true);
        levelGroups[currentLevelIdentifier-1].isCurrentLevel = true;
    }

    // this function looks unneccessary, it could be combined with 'SetLevelAsActive()' instead
    public void LevelChecker()
    {
        DeactivateAllLevelObjects();
        switch(currentLevelIdentifier)
        {
            case 1:
                Debug.Log("level 1 active");
                SetLevelAsActive();
                break;
            case 2:
                Debug.Log("level 2 active");
                SetLevelAsActive();
                break;
            case 3:
                Debug.Log("level 3 active");
                SetLevelAsActive();
                break;
            case 4:
                Debug.Log("level 4 active");
                SetLevelAsActive();
                break;
            case 5:
                Debug.Log("level 5 active");
                SetLevelAsActive();
                break;
            default:
                Debug.Log("No levels active");
                break;
        }
    }

    public void UpdateCurrentLevel()
    {
        levelGroups[currentLevelIdentifier].isComplete = true;
        // need a way to mark each level as 'done' when a collision occurs
        // need to set 'isComplete' to true when level is complete
        // need to set 'isComplete' to false when scene is reset
        currentLevelIdentifier +=1;
        LevelChecker();
    }
}

[System.Serializable]
public class LevelGroups {
    public string levelName = "";
    public GameObject levelObjectParent = null;
    public bool activate = false;
    public bool isComplete = false;
    public bool isCurrentLevel = false;
}
