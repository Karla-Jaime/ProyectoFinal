using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cabana : MonoBehaviour
{
    Renderer render;

    [SerializeField]
    Slider _R;
    [SerializeField]
    Slider _G;
    [SerializeField]
    Slider _B;

    [SerializeField]
    Slider _NormalAmount;

    private void Start()
    {
        render = GetComponent<Renderer>();

    }

    private void Update()
    {
        render.material.SetFloat("_R", _R.value);
        render.material.SetFloat("_G", _G.value);
        render.material.SetFloat("_B", _B.value);
        render.material.SetFloat("_NormalAmount", _NormalAmount.value);
    }

}