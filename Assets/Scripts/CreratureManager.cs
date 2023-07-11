using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreratureManager : MonoBehaviour
{
    private float[] genes;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Color color;
    [SerializeField] float mass;

    // Start is called before the first frame update
    void Start()
    {
        genes = GetComponent<GenesManager>().genesArray;
        CreratureSize();
        CreatureColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreratureSize()
    {
        transform.localScale *= genes[0];
    }

    private void CreatureColor()
    {
        color = new Color(genes[2], genes[3], genes[4]);
        this.GetComponent<SpriteRenderer>().color = color;
    }
}
