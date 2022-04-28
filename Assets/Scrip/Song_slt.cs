using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Song_slt : MonoBehaviour
{
    public AudioClip[] ListSongs;
    public AudioClip currentSng;

    public TextMeshProUGUI _title;


     int index;
    // Start is called before the first frame update
    // void Start()
    // {
         
    // }
    IEnumerator Start()
    {

         index = Random.Range (0, ListSongs.Length);
         currentSng = ListSongs[index];

         
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = currentSng;
        AddsongTextto();
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        audio.clip = currentSng;
        audio.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddsongTextto()
    {
        AudioSource audio = GetComponent<AudioSource>();
        _title.text = "SongName:" + audio.clip.name;
    }
}
