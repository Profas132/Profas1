
using UnityEngine;

public class VolumeValue : MonoBehaviour
{
    private AudioSource _audioSource;
    private float _volume;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        _audioSource.volume = _volume;
    }
    public void SetVoume(float value)
    {
        _volume = value;
    }
}
