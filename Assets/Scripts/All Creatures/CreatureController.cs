using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureController : MonoBehaviour
{
    public GameObject creaturePrefab;
    private float[] genes;
    [SerializeField] float startTime;
    [SerializeField] float elapsedTime;

    void Start()
    {
        startTime = Time.time;

        GetGenes();

        StartCoroutine(Maturity());
    }

    private void GetGenes()
    {
        if (this.GetComponent<DefaultGenesManager>() == null)
            genes = this.GetComponent<GenesManager>().genesArray;
        else
            genes = this.GetComponent<DefaultGenesManager>().genesArray;
    }

    private IEnumerator Maturity()
    {
        yield return new WaitForSeconds(genes[8]); // Wait for maturity

        GameObject child;
        child = Instantiate(creaturePrefab, this.transform.position, Quaternion.AngleAxis(Random.Range(0.0f, 360.0f), Vector3.forward));
        child.GetComponent<GenesManager>().InitializeGenes(genes, Constants.mutationStrength);

        StopCoroutine(Maturity());
    }


    void Update()
    {
        elapsedTime = Time.time - startTime;
    }
}