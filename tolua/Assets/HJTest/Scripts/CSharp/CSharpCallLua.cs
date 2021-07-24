using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpCallLua 
{

    public void DoFile()
    {
        var luaState = LuaStateCore.luaState;
        luaState.DoFile(ConfigPath.LuaFolderPath+ "LuaTest.lua");
    }
}
