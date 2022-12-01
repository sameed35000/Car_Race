using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketEt : MonoBehaviour {

    public WheelCollider OnSol, OnSag, ArkaSol, ArkaSag;

    public float hiz, donmehizi;


    void Start()
    {

    }

    void Update ()
    {
        ArkaSol.motorTorque = hiz * Input.GetAxis("Vertical");
        ArkaSag.motorTorque = hiz * Input.GetAxis("Vertical");
        OnSol.steerAngle = donmehizi * Input.GetAxis("Horizontal");
        OnSag.steerAngle = donmehizi * Input.GetAxis("Horizontal");
    }
}
