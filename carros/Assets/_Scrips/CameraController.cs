using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // The target the camera will follow
    [SerializeField] private float rotationSpeed; // The speed at which the camera will follow the target
    [SerializeField] private float followSpeed; // The speed at which the camera will follow the target
    [SerializeField] private Vector3 offset; // The offset from the target position
                                             // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        FollowTarget();
        RotateToTarget();
    }
    public void FollowTarget()
    {
        if (target != null)
        {
            var targetPos = target.TransformPoint(offset); // Calculate the target position with the offset
            transform.position = Vector3.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime);

        }
    }
    public void RotateToTarget()
    {
        if (target != null)
        {
            var direction = target.position - transform.position; // Calculate the direction to the target
            var rotation = Quaternion.LookRotation(direction); // Calculate the rotation to look at the target
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

        }
    }
}