using UnityEngine;

public class ResetRotation : MonoBehaviour
{
    public float maxTiltAngle = 45f; // Sudut maksimum kemiringan sebelum reset
    public float resetSpeed = 2f;   // Kecepatan reset rotasi

    void Update()
    {
        // Cek kemiringan karakter
        float tiltX = Mathf.Abs(transform.eulerAngles.x);
        float tiltZ = Mathf.Abs(transform.eulerAngles.z);

        // Jika karakter terlalu miring, reset rotasi
        if (tiltX > maxTiltAngle && tiltX < 360 - maxTiltAngle ||
            tiltZ > maxTiltAngle && tiltZ < 360 - maxTiltAngle)
        {
            // Kembalikan rotasi ke posisi tegak
            Quaternion uprightRotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, uprightRotation, resetSpeed * Time.deltaTime);
        }
    }
}
