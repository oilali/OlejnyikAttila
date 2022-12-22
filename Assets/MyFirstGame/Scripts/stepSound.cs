using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepSound : MonoBehaviour
{

    [SerializeField] AudioSource[] sources;

    private void OnValidate()
    {

        sources = GetComponentsInChildren<AudioSource>();

    }

    public void PlayFootstep()
    {

        int randomIndex = Random.Range(0, sources.Length);
        AudioSource source = sources[randomIndex];
        source.Play();

    }


}
