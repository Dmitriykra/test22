using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFX_Controler : MonoBehaviour
{

    [SerializeField] private GameObject neptun;
    [SerializeField] private VisualEffect _visualEffect;
    [SerializeField]

    private Vector3 _transform = new Vector3(-0.0392712988f, -0.0250000004f, 0.152884915f);
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(PlayVFXAfterDelay(3f)); // Play VFX after 3 seconds

    }
    
    IEnumerator PlayVFXAfterDelay(float delay)
    {
        yield return new WaitForSeconds(2f);
        neptun.SetActive(true);
        yield return new WaitForSeconds(delay);
        // Play the Visual Effect
        _visualEffect.Play();
        
       
        
        yield return new WaitForSeconds(0.5f);

        // Stop the Visual Effect
        _visualEffect.Stop();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
