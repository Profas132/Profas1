
using UnityEngine;

public class VolumeValue : MonoBehaviour
{
    private AudioSource _audioSource;
    public float _volume;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        _audioSource.volume = _volume;
        _volume = Global.VolumeV;
    }

    public void SetVoume(float value)
    {
        _volume = value;
    }
}
