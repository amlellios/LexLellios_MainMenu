using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndGame : MonoBehaviour
{
    public void Quit();
        }




#if UNITY_EDITOR
UnityEditor.EditiorApplication.isPlaying=false;

#else
    Application.Quit();

#endif
        

