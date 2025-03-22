using UnityEngine;

{
    Debug.Log("Start");
}

private void Update()
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
    Test();
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

public void Test()
{
    PlayerRotate(5f);
}
}