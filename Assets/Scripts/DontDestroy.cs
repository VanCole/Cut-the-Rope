using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DontDestroy : MonoBehaviour {

    [SerializeField]
    AudioSource audioSource;

    public static bool alreadyMusic;
    
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
        if (alreadyMusic == false)
        {
            AudioSource aaa = Instantiate(audioSource);
            DontDestroyOnLoad(aaa);
            alreadyMusic = true;
            Destroy(gameObject);
        }
    }
}
