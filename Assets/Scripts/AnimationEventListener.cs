using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventListener : MonoBehaviour
{
    [SerializeField] private ParticleSystem fire;
    [SerializeField] private ParticleSystem DeathNove;
    public void FireEvent()
    {
        fire.Play();
        Invoke(nameof(Stop), 1.5f);
    }

    void Stop()
    {
        fire.Stop();
        DeathNove.Stop();
    }
    
    public void DeathNoveEffect()
    {
        DeathNove.Play();
        Invoke(nameof(Stop), 1.5f);
    }
}
