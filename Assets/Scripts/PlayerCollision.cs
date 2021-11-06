using UnityEngine;

public class PlayerCollision : MonoBehaviour
{


    public playerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "endgame")
            movement.enabled = false;
    }
}
