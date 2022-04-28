using System.Collections;
using System.Collections.Generic;
using LootLocker.Requests;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level_ld : MonoBehaviour
{
    private string MemberID;
    public int PlayerScore;

    public GameObject platform;

    public Button Watch_AAd_Button;

    public Button Skip_Restart;

    

    

    private int ID = 2571;
    // Start is called before the first frame update
    private bool reload = true;
    void Start()
    {

        
        if (intToBool(PlayerPrefs.GetInt("name", 0)))
        {
            MemberID = PlayerPrefs.GetString("myString");
            Debug.Log(PlayerPrefs.GetString("myString"));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Destroy")
        {
            platform.transform.eulerAngles = new Vector3(0,0,0);
            Debug.Log(PlayerPrefs.GetInt("score"));
            PlayerScore = PlayerPrefs.GetInt("score");
            MemberID = PlayerPrefs.GetString("myString");
            ButtonShow_fr_ad();
           
        }
    }
    public void SubmitScore()
   {
       LootLockerSDKManager.SubmitScore(MemberID, PlayerScore,ID, (response) =>
    {
       if (response.success)
             {
                 PlayerPrefs.DeleteKey("myString");
                Debug.Log("Success");
             }else
             {
                 PlayerPrefs.DeleteKey("myString");
                  Debug.Log("Failed");
             }
      });
    }
    public void Restart_game()
    {
        if (PlayerScore >1000)
            {
                if (intToBool(PlayerPrefs.GetInt("name", 0)))
                {
                    SubmitScore();
                }
                
            }
            Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Skip_game()
    {
        if (PlayerScore >1000)
            {
                if (intToBool(PlayerPrefs.GetInt("name", 0)))
                {
                    SubmitScore();
                }
                
            }
            Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void continue_Score()
    {
        
        Debug.Log("ad reward game restore");
       
        Time.timeScale = 1;
        PlatfrmCtrl platfrmCtrl = new PlatfrmCtrl();
        platfrmCtrl.continue_Score1();
        
    }
    public void ButtonShow_fr_ad()
    {
        
        Watch_AAd_Button.gameObject.SetActive(true);
        Skip_Restart.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

}
