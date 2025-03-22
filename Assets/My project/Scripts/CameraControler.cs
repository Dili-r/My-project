using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public PlayerMove  playerMove;

    public float sensitivity;
    public float currentY;
    public float minYAngleLimit;
    public float maxYAngleLimit;


    private void Start()
    {
        currentY = transform.localRotation.x;
        currentY = Mathf.Clamp(currentY, minYAngleLimit, maxYAngleLimit);
    }
    
    private void Update ()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
        
        currentY -= mouseY;
        currentY = Mathf.Clamp(currentY, minYAngleLimit, maxYAngleLimit);
        playerMove.PlayerRotate(mouseX);

        transform.localRotation = Quaternion.Euler(currentY, 0f, 0f);
    }

}
