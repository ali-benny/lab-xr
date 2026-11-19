using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeColor : MonoBehaviour
{ 
    [SerializeField] private GameObject cube;
    [SerializeField] private Material[] listMaterialColor;
    private int currentMaterialIndex = 0;

    public void ChangeColor()
    {
        MeshRenderer cubeRenderer = cube.GetComponent<MeshRenderer>();
        
        if (cubeRenderer != null)
        {
            cubeRenderer.material = listMaterialColor[currentMaterialIndex];
            currentMaterialIndex = (currentMaterialIndex + 1) % listMaterialColor.Length;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
