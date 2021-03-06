using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otobushareket : MonoBehaviour
{
    private float MovemntSpeed;
    private float HorSpeed;
    private float hor;

    [SerializeField] ParticleSystem particle;

    [SerializeField] AudioClip _Clip;

    public float _currentRunningSpeed;
    public float xSpeed;
    public float limitX;

    void Start()
    {
        particle.Play();
        SoundManager.Instance.PlaySound(_Clip);
    }
    public void Update()
    {
        float newX = 0;
        float touchXDelta = 0;
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchXDelta = Input.GetTouch(0).deltaPosition.x / Screen.width;
        }
        else if (Input.GetMouseButton(0))
        {
            touchXDelta = Input.GetAxis("Mouse X");
        }

        newX = transform.position.x + xSpeed * touchXDelta * Time.deltaTime;
        newX = Mathf.Clamp(newX, -limitX, limitX);

        Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z + _currentRunningSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
    public void ChangeSpeed(float value)
    {
        _currentRunningSpeed = value;
    }
}