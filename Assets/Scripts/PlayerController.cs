using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.5f;
    private float turnSpeed = 40.0f;

    float horizontalInput;
    float forwardInput;

    #region Added for Hard Challenge
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    #endregion


    #region Added for Expert Challenge
    public string inputID;
    #endregion

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        #region Updated for Expert Challenge
        // Axis setup
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        #endregion

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotate the vehicle left and right
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        #region Added for Hard Challenge
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
        #endregion
    }
}
