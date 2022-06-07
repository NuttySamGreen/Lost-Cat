using UnityEngine;

public class camera : MonoBehaviour
{
    private Transform _TCamera_transform;
    private Transform _transform_parent;

    private Vector3 _PersonalRotation;
    private float Cam_distance;

    public float Mouse_sensitivity = 4f;
    public float Scroll_sensitivity = 2f;
    public float OrbitDampening = 10f;
    public float ScrollDampening = 6f;
    // Start is called before the first frame update
    void Start()
    {
        this._TCamera_transform = this.transform;
        this._transform_parent = this.transform.parent;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            _PersonalRotation.x += Input.GetAxis("Mouse x") * Mouse_sensitivity;
            _PersonalRotation.y -= Input.GetAxis("Mouse Y") * Mouse_sensitivity;

            _PersonalRotation.y = Mathf.Clamp(_PersonalRotation.y, 0f, 90f);
        }
    }
}
