using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ButtonAudio : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    public void OnMouseDown()
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
