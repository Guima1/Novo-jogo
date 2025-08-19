using UnityEngine;

public class CarController : MonoBehaviour
{   //Fncionalidade do carro
    //acelerar o carro
    //freiar carro
    //girar o carro
    //girar o carro para a esquerda
    //girar o carro para a direita
    //freio de mão
    //ligar desligar farol

    //Propriedes do carro
    [SerializeField]
    private float speed = 50f;
    [SerializeField]
    private bool isBraking = false;
    [SerializeField]
    private float torque = 1000f;
    [SerializeField]
    private Light light;

    [SerializeField]
    private Transform leftFrontWellCollider;

    [SerializeField]
    private Transform rightFrontWellCollider;

    [SerializeField]
    private Transform leftBackWellCollider;

    [SerializeField]
    private Transform rightBackWellCollider;


    [SerializeField]
    private WheelCollider leftFrontWheel;

    [SerializeField]
    private WheelCollider rightFrontWheel;

    [SerializeField]
    private WheelCollider leftBackWheel;

    [SerializeField]
    private WheelCollider rightBackWheel;

    private void FixedUpdate()
    {
        speedCar();
        brakeCar();
        lightCar();
    }

    private void speedCar()
    {
        if (Input.GetKey(KeyCode.W))
        {
            leftFrontWheel.motorTorque = torque;
            rightFrontWheel.motorTorque = torque;
        }
        if (Input.GetKey(KeyCode.S))
        {
            leftFrontWheel.motorTorque = torque;
            rightFrontWheel.motorTorque = torque;
        }
        if (Input.GetKey(KeyCode.A))
        {
            leftFrontWheel.motorTorque = torque;
            rightFrontWheel.motorTorque = torque;
        }
        if (Input.GetKey(KeyCode.D))
        {
            leftFrontWheel.motorTorque = torque;
            rightFrontWheel.motorTorque = torque;
        }
    }

    private void brakeCar()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            leftFrontWheel.brakeTorque = torque;
            rightFrontWheel.brakeTorque = torque;
        }
    }
    private void lightCar()
    {
        if (Input.GetKey(KeyCode.L))
        {
            light.enabled = !light.enabled;
        }
    }
}
