using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;

public class SliderInput : MonoBehaviour
{
    [SerializeField]
    private GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSliderChange(float value)
    {
        door.transform.localPosition = new Vector3(0,(float)(value * -4.5),0);
    }
}
