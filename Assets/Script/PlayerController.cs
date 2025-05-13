using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Turn;
    public float speed = 5.0f;
    public float horizontal = 26.0f;
    public float forwordlinput;
    void Update()
    {
       
        horizontal = Input.GetAxis("Horizontal");
        forwordlinput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwordlinput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * Time.deltaTime * horizontal);
        transform.Rotate(Vector3.left * Time.deltaTime * horizontal);
    }
}
