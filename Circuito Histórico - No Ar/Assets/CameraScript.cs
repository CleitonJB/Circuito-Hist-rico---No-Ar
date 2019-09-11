using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    private Quaternion Rota;

    private Vector3 Cam;

    public Vector3 Camera;

    private Animation Anm;

    public bool Reset;

    void Start()
    {
        Rota = Quaternion.Euler(0, 270, 0);

        Anm = GetComponent<Animation>();

        Reset = false;
    }

    void Update()
    {
        Camera = GameObject.Find("Camera").transform.eulerAngles;

        Debug.Log("X: " + Camera.x + "; Y: " + Camera.y + "; Z: " + Camera.z);

        if (Input.GetKeyDown("space") && Anm.isPlaying == false)
        {
            Debug.Log("Prefiro morrer do quê perder a vida");
            Anm.Play();
        }

        if (Anm.isPlaying)
        {
            Debug.Log("Animação em andamento");
            Debug.Log("Dando umas olhadas");

            Reset = true;
        }

        if (Reset == true && !Anm.isPlaying)
        {
            ResetRotacao();
        }
    }

    void ResetRotacao()
    {
        Debug.Log("Zerando la rotacion");

        GameObject.Find("Camera").transform.rotation = Rota;
        GameObject.Find("Camera").transform.eulerAngles = new Vector3(0, 270, 0);

        Reset = false;
    }
}






