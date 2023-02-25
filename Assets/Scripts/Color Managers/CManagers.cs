using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CManagers : MonoBehaviour
{
    [SerializeField]
    private LineSettings lineSettings = null;

    [SerializeField] private Material MaterialBasic;

    [SerializeField] private Material MaterialRed;

    [SerializeField] private Material MaterialBlue;

    [SerializeField] private Material MaterialGreen;

    [SerializeField] private Material MaterialDefult;


    public void changeRed()
    {
        lineSettings.defaultMaterial = MaterialRed;
    }

    public void changeBloo()
    {
        lineSettings.defaultMaterial = MaterialBlue;
    }

    public void changegreen()
    {
        lineSettings.defaultMaterial = MaterialGreen;
    }

    public void changeDefoult()
    {
        lineSettings.defaultMaterial = MaterialDefult;
    }
}