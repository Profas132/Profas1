using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ERJAN : MonoBehaviour
{
    [SerializeField] private AudioSource ErjanSong;

    private void OnMouseDown()
    {
        ErjanSong.Play();
    }

}
