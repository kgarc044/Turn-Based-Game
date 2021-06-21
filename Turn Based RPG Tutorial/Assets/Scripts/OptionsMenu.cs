using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField]
    public static float animationSpeed = 1f;

    public void SetAnimationSpeed(float newSpeed)
    {
        animationSpeed = newSpeed * 10;
    }
    
    public float  GetAnimationSpeed()
    {
        return animationSpeed;
    }
}

