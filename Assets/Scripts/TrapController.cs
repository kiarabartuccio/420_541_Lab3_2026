using UnityEngine;

public class TrapController : MonoBehaviour
{
    // How fast the trap rotates
    public float rotationSpeed = 100f;

    // Stores the Rigidbody attached to the trap
    private Rigidbody rb;

    // Runs once when the game starts
    void Start()
    {
        // Get the Rigidbody from the trap
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate is used for physics
    void FixedUpdate()
    {
        // Calculate how much the trap should rotate this physics frame
        Quaternion deltaRotation = Quaternion.Euler(
            0,
            rotationSpeed * Time.fixedDeltaTime,
            0
        );

        // Rotate using the Rigidbody
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}


