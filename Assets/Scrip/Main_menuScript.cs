using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Main_menuScript : MonoBehaviour
{
    public bool GotName = false;
    public InputField MemberID;
    public GameObject NameBox;
     public TextMeshProUGUI _title;

    void Start()
    {
         if (intToBool(PlayerPrefs.GetInt("name", 0)))
        {
           NameBox.SetActive(false);
        }
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    public void Play() 
    {
        _title.gameObject.SetActive(true);
        SceneManager.LoadScene(1);

        
    } 
     
    public void leaderBoard() 
    {
        SceneManager.LoadScene(3);
    }
     
    public void Quit() 
    {
         Application.Quit();
    } 

    public void Songs()
    {
        Debug.Log("Songs");          
    }
    int boolToInt(bool val)
{
    if (val)
        return 1;
    else
        return 0;
}

bool intToBool(int val)
{
    if (val != 0)
        return true;
    else
        return false;
}

 public void GotTheName()
 {
     
     GotName = true;
     NameBox.SetActive(false);
     PlayerPrefs.SetInt("name", boolToInt(GotName));
     PlayerPrefs.SetString("myString", MemberID.text);
 }
 public void NotName()
 {
     NameBox.SetActive(false);
     GotName = false;
     PlayerPrefs.SetInt("name", boolToInt(GotName));
 }
}


