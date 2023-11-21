using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicFurnaceScript : MonoBehaviour
{

    public int _multiplier;

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ore"))
        {
            var _ore = collision.gameObject;
            var _oreScript = _ore.GetComponent<OreScript>();
            GlobalVars._money += Mathf.RoundToInt(_oreScript.value * _multiplier);
            Destroy(_ore);

            Debug.Log(GlobalVars._money);
        }

    }

}
