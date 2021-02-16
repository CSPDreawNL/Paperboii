using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	
	static MusicManager instance = null;
	private AudioSource audioSource;
	
	void Awake() {
		if (instance != null) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");	}
		else {	instance = this;
			GameObject.DontDestroyOnLoad(gameObject);	}
	}

    private void Start()
    {
		audioSource = GetComponent<AudioSource>();
    }

    public void ChangeVolume(float volume)
    {
		audioSource.volume = volume;
    }
}