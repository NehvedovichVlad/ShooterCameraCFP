using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _camera;
    [SerializeField] private int _speed;
    private float _xRotation;

    private void Update()
    {
        _xRotation -= Input.GetAxis("Mouse Y");
        _xRotation = Mathf.Clamp(_xRotation, -30f, 30f);
        _camera.localEulerAngles = new Vector3(_xRotation, _camera.localEulerAngles.y, 0f);


        RotateAroundCenter();


    }

    private void RotateAroundCenter()
    {
        _camera.RotateAround(_target.position, -transform.up,
                                _speed * Input.GetAxis("Horizontal") * Time.deltaTime);

    }
}
 