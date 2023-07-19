using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultCreratureInitializer : MonoBehaviour
{
    private float[] genes;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Color color;

    void Start()
    {   // Get genes
        genes = GetComponent<DefaultGenesManager>().genesArray;

        CreatureSize();
        CreatureMass();
        CreatureColor();
    }

    private void CreatureSize()
    {
        transform.localScale *= genes[0];
    }

    private void CreatureMass()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = genes[2];
    }

    private void CreatureColor()
    {
        color = new Color(genes[2], genes[3], genes[4]);
        this.GetComponent<SpriteRenderer>().color = color;
    }
}