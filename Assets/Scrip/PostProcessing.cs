using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessing : MonoBehaviour
{
    private Bloom thisBloom;

    public PostProcessVolume volume;

    // Start is called before the first frame update
    void Start()
    {
        
        volume.profile.TryGetSettings(out thisBloom);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PostProcessingEnable()
    {
        thisBloom.active = true;
    }
    public void PostProcessingEnableDisable()
    {
        thisBloom.active = false;
    }
}
