using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {// breytir staðsetningu hlutarins í staðsetningu kubbsins + ákveðið offset
        transform.position = player.position + offset;
    }
}
