using UnityEngine;

public class Rotate : MonoBehaviour
{

    private float speed = 100f;
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
