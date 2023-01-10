using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    GameObject playerParentObject = null;
    
    [SerializeField]
    GameObject startLevelButton = null;

    [SerializeField]
    int deathCounter;

    [SerializeField]
    TextMeshProUGUI textMisses;

    [SerializeField]
    FollowTransform followTransform;

    void Start()
    {
        
        WaitToStart();
        LoadData();
    }

    public void ControlPlayer(){
        playerParentObject.SetActive(true);
        startLevelButton.SetActive(false);
        followTransform.EnableFollowing();
    }

    public void WaitToStart(){
        playerParentObject.SetActive(false);
        startLevelButton.SetActive(true);
    }

    public void PlayerHasDied()
    {
        deathCounter +=1;
        SetDeathCounterToText(deathCounter);
        SaveData();
        followTransform.DisableFollowing();
    }

    public void SetDeathCounterToText(int x){
        textMisses.text = x.ToString();
    }

    public void SaveData(){
        PlayerPrefs.SetInt("numberOfDeaths", deathCounter);
        PlayerPrefs.Save();
    }

    public void LoadData(){
        deathCounter = PlayerPrefs.GetInt("numberOfDeaths");
        SetDeathCounterToText(deathCounter);
    }

    public void ClearData(){
        PlayerPrefs.DeleteKey("numberOfDeaths");
        PlayerPrefs.SetInt("numberOfDeaths", 0);
        PlayerPrefs.Save();
    }
}
