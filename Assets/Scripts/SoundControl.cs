using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundControl : MonoBehaviour
{
    private bool muted = false;

    public void OnButtonClick()
    {
        if(muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
    }



}
