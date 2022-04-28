using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
using TMPro;
using UnityEngine.SceneManagement;

public class Platfrm2D : MonoBehaviour
{
    private float Dirx;
    private float Diry;
    private float Dirz;
    public float Speed;
    private int score;

    public Button Watch_AAd_Button;

    
    public Button Skip_Restart;

    public Slider slider;

    [SerializeField]
    public TextMeshProUGUI _title;
    public PostProcessing ps;





    // Start is called before the first frame update
    void Start()
    { 
      PostProcessingfun();
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
        
        
    //  if (transform.rotation.eulerAngles.z >= 160f && transform.rotation.eulerAngles.z<= 200f)
    //  {
         
         transform.Rotate(0,0,Dirx*Speed);
    //  }
    //  else if (transform.rotation.eulerAngles.z <= 160f)
    //  {
    //      transform.Rotate(0,0,161f);
    //  }
    //  else if (transform.rotation.eulerAngles.z>= 200f)
    //  {
    //      transform.Rotate(0,0,199f);
    //  }
    }
    private void LateUpdate() {
        Debug.Log(transform.rotation.eulerAngles.z);
        transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z);    
    }

    void PostProcessingfun()
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
                    SceneManager.LoadScene(3);
                }
                
            }
        if (score >= 30000)
            {
                
                int lv = SceneManager.GetActiveScene().buildIndex;
                if (lv == 1)
                {
                    PlayerPrefs.SetInt("score", score);
                    SceneManager.LoadScene(3);
                }
                
            }    
    }
     public void continue_Score2()
    {
        Debug.Log("ad reward game restore");
        score = PlayerPrefs.GetInt("score");

        Debug.Log(score);
        
    }
}
