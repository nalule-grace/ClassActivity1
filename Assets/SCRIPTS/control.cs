using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class control : MonoBehaviour
{
    [SerializeField] private TMP_Text displaytxt;
    [SerializeField] private RawImage displayIMG;
    [SerializeField] private ScriptableObjectscript items;

    public void generate()
    {
        displaytxt.text = items.Mystring;
        displayIMG.texture = items.Mytexture;
    }
}
