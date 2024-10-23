using HyperCasual.Runner;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class KeyboardManager : MonoBehaviour
{
    

#if !UNITY_EDITOR && UNITY_WEBGL
    [DllImport("__Internal")]
    private static extern void GetDeviesType();
#endif


    void Start()
    {

#if !UNITY_EDITOR && UNITY_WEBGL
        GetDeviesType();
#endif

    }

    public void OnGetDeviesType(string devicetype)
    {
        devicetype = devicetype.Replace("\"", "");
        Debug.Log("devicetype::>>>>" + devicetype);

        GameManager.Instance.IsMobile = (devicetype == "yes");

    }
}
