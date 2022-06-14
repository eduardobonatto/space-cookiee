using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra : MonoBehaviour
{
    public Slider slider;
    
   public void SetMaxVida(int life)
    {
        slider.maxValue= life;
        slider.value= life;
    }
   public  void SetHelth(int life)
    {
        slider.value= life;
    }  
}
