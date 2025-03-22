using UnityEngine;
Vector3 movementForward = transform.forward * moveVertical;

Vector3 movementRight = transform.right * moveHorizontal;

Vector3 movemenetUp = new Vector3(0f, rigi.linearVelocity.y, 0f);

rigi.linearVelocity = (movementForward + movementRight) * speed + movemenetUp;

if (Input.GetKeyDown(KeyCode.Space))
{
    Jump();
}
        }
    }

    private void Jump()
{
    rigi.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
}

private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.GetComponent<Ground>() == true)
    {
        isGrounded = true;
    }
}

private void OnCollisionExit(Collision collision)
{
    if (collision.gameObject.GetComponent<Ground>() == true)
    {
        isGrounded = false;
    }
}
}