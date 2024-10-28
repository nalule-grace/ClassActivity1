using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class controlscript : MonoBehaviour
{
    [SerializeField] private Text displaytxt;
    [SerializeField] private RawImage displayIMG;
    [SerializeField] private ScriptableObjectscript items;

    public void generate()
    {
        displaytxt.text = items.Mystring;
        displayIMG.texture = items.Mytexture;
    }
}
