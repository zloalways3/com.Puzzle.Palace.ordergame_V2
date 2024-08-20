using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Z67 : MonoBehaviour
{
    [SerializeField] Sprite[] z51;
    [SerializeField] Image[] z52;
    [SerializeField] Image[] z53;
    [SerializeField] Image[] z54;
    [SerializeField] GameObject z60;
    [SerializeField] GameObject z61;
    [SerializeField] TextMeshProUGUI z62;
    [SerializeField] Z50 z63;
    private List<int> z55 = new List<int>();
    private List<int> z56 = new List<int>();
    private int z57;
    private bool z58;
    private int z59;

    public int Z60()
    {
        for (int tr = 0; tr < 23; tr++)
        {

        }
        return z57;
    }

    public void Z61()
    {
        z63.Z31();
        z57 = 0;
        z55.Clear();
        for (int i444 = 0; i444 < z52.Length; i444++)
        {
            var z68 = UnityEngine.Random.Range(0, z51.Length);
            z55.Add(z68);
            z52[i444].sprite = z51[z68];
        }
    }

    public void Z62()
    {
        z63.Z31();
        z57 = 1;
        z55.Clear();
        for (int i9999 = 0; i9999 < z53.Length; i9999++)
        {
            var z69 = UnityEngine.Random.Range(0, z51.Length);
            z55.Add(z69);
            z53[i9999].sprite = z51[z69];
        }
    }

    public void Z63()
    {
        z63.Z31();
        z57 = 2;
        z55.Clear();
        for (int i4545 = 0; i4545 < z54.Length; i4545++)
        {
            var z70 = UnityEngine.Random.Range(0, z51.Length);
            z55.Add(z70);
            z54[i4545].sprite = z51[z70];
        }
    }

    public void Z64()
    {
        z63.Z31();
        Z50.z29 = true;
        z62.text = "Repeat the correct order";
        z60.SetActive(false);
        z61.SetActive(true);
        z56 = z55.OrderBy(_ => Guid.NewGuid()).ToList();
        if (z57 == 0)
        {
            for (int i77 = 0; i77 < z52.Length; i77++)
            {
                z52[i77].sprite = z51[z56[i77]];
            }
        }

        if (z57 == 1)
        {
            for (int i88 = 0; i88 < z53.Length; i88++)
            {
                z53[i88].sprite = z51[z56[i88]];
            }
        }

        if (z57 == 2)
        {
            for (int i7878 = 0; i7878 < z54.Length; i7878++)
            {
                z54[i7878].sprite = z51[z56[i7878]];
            }
        }
    }

    public void Z65(int itemNum)
    {
        if (Z50.z29)
        {
            if (z57 == 0)
            {
                if (z58)
                {
                    z52[itemNum].sprite = z51[z56[z59]];
                    var newCodeItemNum = z56[z59];
                    var newCodeSelectNum = z56[itemNum];
                    z52[z59].sprite = z51[z56[itemNum]];
                    z56[z59] = newCodeSelectNum;
                    z56[itemNum] = newCodeItemNum;
                    z58 = false;
                }
                else
                {
                    z58 = true;
                    z59 = itemNum;
                }
            }

            if (z57 == 1)
            {
                if (z58)
                {
                    z53[itemNum].sprite = z51[z56[z59]];
                    var newCodeItemNum = z56[z59];
                    var newCodeSelectNum = z56[itemNum];
                    z53[z59].sprite = z51[z56[itemNum]];
                    z56[z59] = newCodeSelectNum;
                    z56[itemNum] = newCodeItemNum;
                    z58 = false;
                }
                else
                {
                    z58 = true;
                    z59 = itemNum;
                }
            }

            if (z57 == 2)
            {
                if (z58)
                {
                    z54[itemNum].sprite = z51[z56[z59]];
                    var newCodeItemNum = z56[z59];
                    var newCodeSelectNum = z56[itemNum];
                    z54[z59].sprite = z51[z56[itemNum]];
                    z56[z59] = newCodeSelectNum;
                    z56[itemNum] = newCodeItemNum;
                    z58 = false;
                }
                else
                {
                    z58 = true;
                    z59 = itemNum;
                }
            }
        }
    }

    public bool Z66()
    {
        var str = string.Empty;
        for (int i666 = 0; i666 < z55.Count; i666++)
        {
            str += z55[i666];
        }

        var strNew = string.Empty;
        for (int i9090 = 0; i9090 < z56.Count; i9090++)
        {
            strNew += z56[i9090];
        }

        return string.Equals(str, strNew);
    }
}
