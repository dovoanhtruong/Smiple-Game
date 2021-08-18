using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefs
{
  public static int bestScore{
      set{
          if(PlayerPrefs.GetInt(PrefConsts.BEST_SCORE,0)< value){
              PlayerPrefs.SetInt(PrefConsts.BEST_SCORE,value);
          }
      }
      get => PlayerPrefs.GetInt(PrefConsts.BEST_SCORE,0);

  }

  }

