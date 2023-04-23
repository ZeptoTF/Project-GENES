using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreratureManager : MonoBehaviour
{
    private float[] genes;
    [SerializeField] Color color;

    // Start is called before the first frame update
    void Start()
    {
        genes = GetComponent<GenesManager>().genesArray;
        CreatureColor();
        CreratureSizeXY();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreatureColor()
    {
        color = new Color(genes[0], genes[1], genes[2]);
        this.GetComponent<SpriteRenderer>().color = color;
    }

    private void CreratureSizeXY()
    {
        transform.localScale = new Vector3(genes[3], genes[4], 1);
    }
}
