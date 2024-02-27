using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    [SerializeField] float forwardSpeed = 25;
    [SerializeField] float strafeSpeed = 7.5f;
    [SerializeField] float hoverSpeed = 5;

    [SerializeField] float rollSpeed = 90;
    [SerializeField] float rollAcceleration = 3.5f;

    [SerializeField] float lookRateSpeed = 90;

    private float currentForwardSpeed, currentStrafeSpeed,
        currentHoverSpeed;
    private float forwardAcceleration = 2.5f, strafeAcceleration = 2, hoverAcceleration = 2;


    private Vector2 lookInput, screenCenter, mouseDistance;

    private float rollInput;

    void Start()
    {
        screenCenter.x = Screen.width * 0.5f;
        screenCenter.y = Screen.height * 0.5f;

        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        lookInput = Input.mousePosition;

        mouseDistance = (lookInput - screenCenter) / screenCenter;

        mouseDistance = Vector2.ClampMagnitude(mouseDistance, 1f);

        rollInput = Mathf.Lerp(rollInput, Input.GetAxisRaw("Roll"), rollAcceleration * Time.deltaTime);

        var yRotate = -mouseDistance.y * lookRateSpeed * Time.deltaTime;
        var xRotate = mouseDistance.x * lookRateSpeed * Time.deltaTime;
        var zRotate = rollInput * rollSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(yRotate, xRotate, zRotate), Space.Self);

        currentForwardSpeed = Mathf.Lerp(currentForwardSpeed, Input.GetAxisRaw("Vertical") * forwardSpeed, forwardAcceleration * Time.deltaTime);
        currentStrafeSpeed = Mathf.Lerp(currentStrafeSpeed, Input.GetAxisRaw("Horizontal") * strafeSpeed, strafeAcceleration * Time.deltaTime);
        currentHoverSpeed = Mathf.Lerp(currentHoverSpeed, Input.GetAxisRaw("Flying") * hoverSpeed, hoverAcceleration * Time.deltaTime);

        transform.position += transform.forward * currentForwardSpeed * Time.deltaTime;
        transform.position += (transform.right * currentStrafeSpeed * Time.deltaTime) + (transform.up * currentHoverSpeed * Time.deltaTime);
    }
}