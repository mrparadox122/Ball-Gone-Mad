using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
using TMPro;
using UnityEngine.SceneManagement;

public class PlatfrmCtrl : MonoBehaviour
{
    private float Dirx;
    private float Diry;
    private float Dirz;
    public float Speed;
    private int score;

    public Button Watch_AAd_Button;


    public Button Skip_Restart;

    [SerializeField]
    public TextMeshProUGUI _title;
    public PostProcessing ps;

    public Slider slider;




    // Start is called before the first frame update
    void Start()
    { 
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
      PostProcessingfun();
      
    //   slider = gameObject.GetComponent<Slider>();
      
      int lvs = PlayerPrefs.GetInt("score");
      if (lvs >= 10000)
      {
          score = PlayerPrefs.GetInt("score");
      }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Dirx = -Input.acceleration.x;
        Diry = Input.acceleration.y;
        Dirz = Input.acceleration.z;
        transform.Rotate(Diry*Speed,0,Dirx*Speed);
    }
    private void LateUpdate() {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 0, transform.localEulerAngles.z);    
    }

    public void PostProcessingfun()
    {
        Watch_AAd_Button.gameObject.SetActive(false);
        Skip_Restart.gameObject.SetActive(false);
        
    }
    private void OnCollisionStay(Collision other) {
        if (other.gameObject.tag == "Ball")
        {
            ps.PostProcessingEnable();
            score++;
            nwLvlLoad();
             _title.text = "Score:"+score;
             slider.value = score;
        }
    }
    private void OnCollisionExit(Collision other) {
        if (other.gameObject.tag == "Ball")
        {
            PlayerPrefs.SetInt("score", score);
            ps.PostProcessingEnableDisable();
        }
    }
    public void nwLvlLoad()
    {
        if (score >= 10000)
            {
                
                int lv = SceneManager.GetActiveScene().buildIndex;
                if (lv == 1)
                {
                    PlayerPrefs.SetInt("score", score);
                    SceneManager.LoadScene(2);
                }
                
            }
        if (score >= 20000)
            {
                
                int lv = SceneManager.GetActiveScene().buildIndex;
                if (lv == 1)
                {
                    PlayerPrefs.SetInt("score", score);
                    SceneManager.LoadScene(2);
                }
                
            }
        if (score >= 30000)
            {
                
                int lv = SceneManager.GetActiveScene().buildIndex;
                if (lv == 1)
                {
                    PlayerPrefs.SetInt("score", score);
                    SceneManager.LoadScene(2);
                }
                
            }    
    }

    public void continue_Score1()
    {
        Debug.Log("ad reward game restore");
        score = PlayerPrefs.GetInt("score");

        Debug.Log(score);
        
    }
    
}
