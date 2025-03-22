using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int speed;
    public float Float;
    public string String;
    public bool Bool;

    public Transform moveTransform;


    private void Awake()
    {
        Debug.Log ("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    void Start()
    {
        Debug.Log("Start");
    }
    
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movementForward = transform.forward * moveVertical;

        Vector3 movementRight = transform.right * moveHorizontal;
        transform.position += (movementForward + movementRight) * speed * Time.deltaTime;

        Debug.Log("Update");
    }
    private void OnDisable()
    {

        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
    public void PlayerRotate(float mouseInputX)
    {
        transform.Rotate(Vector3.up * mouseInputX);

    }
}
