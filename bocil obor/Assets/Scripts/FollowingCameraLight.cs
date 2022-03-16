using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCameraLight : MonoBehaviour
{
    //buat var untuk menentukan kecepatan kursor saat bergerak
    public float panSpeed = 0.1f;

    //buat var untuk menentukan tebal bordernya
    public float panBorder = 1;

    private void Update()
    {
        //buat var yang menampung transform.position
        Vector3 pos = transform.position;

        //kalau input mouse secara horizontal ke atas 
        if (Input.mousePosition.y >= Screen.height - panBorder)
        {
            pos.y += panSpeed * Time.deltaTime;
        }

        //kalau input mouse secara horizontal ke bawah 
        if (Input.mousePosition.y <= panBorder)
        {
            pos.y -= panSpeed * Time.deltaTime;
        } 
        
        //kalau input mouse secara vertikal ke kanan 
        if (Input.mousePosition.x >= Screen.width - panBorder)
        {
            pos.x += panSpeed * Time.deltaTime;
        }

        //kalau input mouse secara vertikal ke kiri 
        if (Input.mousePosition.x <= panBorder)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        //kita return dengan mengasign value pos
        transform.position = pos;
    }
}
