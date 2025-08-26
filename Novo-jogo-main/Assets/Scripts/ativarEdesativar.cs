using UnityEngine;

public class ativarEdesativar : MonoBehaviour
{
    private float speed = 100f;
    void Update(){
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);
    }
    void OnEnable(){

    Debug.Log("objeto habilitade");
    }

    void OnDisable()
    {
    Debug.Log("objeto desabilitado");
    }

}