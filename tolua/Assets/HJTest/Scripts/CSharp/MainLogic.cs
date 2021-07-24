using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLogic : MonoBehaviour
{
    // Start is called before the first frame update

    CSharpCallLua cSharpCallLua;

    void Start()
    {
        LuaStateCore.luaState.Start();
        cSharpCallLua = new CSharpCallLua();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cSharpCallLua.DoFile();
        }
    }
}
