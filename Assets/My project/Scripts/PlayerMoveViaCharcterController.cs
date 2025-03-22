using UnityEngine;

public class PlayerMoveViaCharcterController : MonoBehaviour
{
    public CharacterController characterController;

    public float moveSpeed;

    public float jumpHeight;

    public float gravity;

    public bool isGrounded;

    public Vector3 moveDirection;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        isGrounded = characterController.isGrounded;

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            moveDirection.y = jumpHeight;
        }

        float horizontalMove = Input.GetAxis("Horizontal");
        float VertiacalMove = Input.GetAxis("Vertical");

        Vector3 movementForward = transform.forward * VertiacalMove;

        Vector3 movementRight = transform.right * horizontalMove;

        characterController.Move((movementForward + movementRight) * moveSpeed * Time.deltaTime);

        if (isGrounded == false)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        characterController.Move(moveDirection);
    }
}
