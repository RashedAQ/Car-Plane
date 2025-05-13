using UnityEngine;

public class FollowPlayers : MonoBehaviour
{
    private Vector3 offsetMyCameraPosition = new Vector3(0, 5, -12) ;
    public GameObject player;

    void LateUpdate()
    {
        transform.position = player.transform.position + offsetMyCameraPosition;
    }
}
