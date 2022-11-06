
using UnityEngine;

public class VolumeChange : MonoBehaviour
{
    private void Start()
    {
        Global.VolumeV = 0.5f;    
    }

    public void setvolume(float val)
    {
        Global.VolumeV = val;
    }
}
