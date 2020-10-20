using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBlockDamage : MonoBehaviour
{
    public GameObject BlockDamageDone;

    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision co)
    {
        Debug.Log("blockDameDone");
        var blockDameDone = Instantiate(BlockDamageDone, transform);
        var pSR = blockDameDone.GetComponent<ParticleSystemRenderer>();
        mat = pSR.material;
        mat.SetVector("_blockDameCenter", co.contacts[0].point);

        Destroy(blockDameDone, 2);
    }
}
