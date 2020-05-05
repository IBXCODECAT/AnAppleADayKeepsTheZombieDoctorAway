using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoil : MonoBehaviour
{
    public Transform recoilMod;
    public GameObject weapon;
    public float maxRecoil_x = 10;
    public float recoilSpeed = 10;
    float recoil = 0.0f;

    public void Fire()
    {
            //every time you fire a bullet, add to the recoil.. of course you can probably set a max recoil etc..
            recoil += 0.1f;
        
    }

    void Update()
    {
        recoiling();
    }

    void recoiling()
    {
        if (recoil > 0)
        {
            var maxRecoil = Quaternion.Euler(maxRecoil_x, 0, 0);
            // Dampen towards the target rotation
            recoilMod.rotation = Quaternion.Slerp(recoilMod.rotation, maxRecoil, Time.deltaTime * recoilSpeed);
            weapon.transform.localEulerAngles = new Vector3(recoilMod.localEulerAngles.x, 0, 0);
            recoil -= Time.deltaTime;
        }
        else
        {
            recoil = 0;
            var minRecoil = Quaternion.Euler(0, 0, 0);
            // Dampen towards the target rotation
            recoilMod.rotation = Quaternion.Slerp(recoilMod.rotation, minRecoil, Time.deltaTime * recoilSpeed / 2);
            weapon.transform.localEulerAngles = new Vector3(recoilMod.localEulerAngles.x, 0, 0);
        }
    }
}
