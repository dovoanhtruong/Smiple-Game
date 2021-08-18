using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControler : MonoBehaviour
{
public static AudioControler Ins;


 public float musicVolume;

public float soundVolume;

    public AudioSource musicAus;
    public AudioSource soundAus;

    public AudioClip[] backgroundMusics;
    public AudioClip rightSound;
    public AudioClip loseSound;
    public AudioClip winSound;

    public AudioClip dartPhong;
    public AudioClip AYR;
    public AudioClip dartNotOk;

    private void Awake(){
        MakeSingleton();
    } 
    // Start is called before the first frame update
    void Start()
    {
        PlayBackgroundMusic();
    }

private void Update(){
    if(musicAus && soundAus){
        musicAus.volume=musicVolume;
        soundAus.volume=soundVolume;
    }
}

    // Update is called once per frame
public void PlayBackgroundMusic(){
    if(musicAus && backgroundMusics != null && backgroundMusics.Length >0)
{
    int randIdx =Random.Range(0,backgroundMusics.Length);
    if(backgroundMusics[randIdx]){
        musicAus.clip=backgroundMusics[randIdx];
        musicAus.volume=musicVolume;
        musicAus.Play();
    }
}
}

  public void PlaySound(AudioClip sound){
      if(soundAus && sound) {
          soundAus.volume=soundVolume;
  soundAus.PlayOneShot(sound);
      }
    
  }
  public void PlayRightSound(){
      PlaySound(rightSound);
  }

    public void PlayLoseSound(){
      PlaySound(loseSound);
  }

    public void PlayWinSound(){
      PlaySound(winSound);
  }

public void StopMusic(){
    if(musicAus)
    musicAus.Stop();
}
    public void PlayDartPhongSound(){
      PlaySound(dartPhong);

  }
      public void PlayDartNotOkSound(){
      PlaySound(dartNotOk);
  }

    public void PlayDartStartSound(){
      PlaySound(AYR);
  }

   public void MakeSingleton(){
     if(Ins == null){
         Ins = this;
     }else{
         Destroy(gameObject);
     }
}
}
