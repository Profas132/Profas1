using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] private float maxValueY;
    [SerializeField] private float minValueY;
    [SerializeField] private float ZoomScale = 8.08745f; //чем меньше тем крупнее зум
    private Camera cum;

    private void Start()
    {
        Player = FindObjectOfType<PlayerMover>().gameObject;
        cum = GetComponent<Camera>();
    }
    void LateUpdate()
    {
        cameraMovement();
    }
    private void cameraMovement()
    {
        Vector3 p = Player.transform.position;
        p.x = transform.position.x;
        p.z = transform.position.z;
        if (maxValueY > Player.transform.position.y && Player.transform.position.y > minValueY)
        {
            transform.position = p;
        }
    }
    public void OnZoom()//вызывай этот метод для зума
    {
        cum.orthographicSize = ZoomScale;
    }
}
