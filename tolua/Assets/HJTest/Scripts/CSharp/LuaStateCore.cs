using LuaInterface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaStateCore 
{
    private static LuaState m_luaState;
    public static LuaState luaState
    {
        get {
            if (m_luaState == null)
            {
                m_luaState = new LuaState();
                return m_luaState;
            }
            return m_luaState;
        }
    }
    public void Init()
    {
        
    }
    public void Start() 
    {
        m_luaState.Start();
    }
    public void Dispose()
    {
        m_luaState.Dispose();
    }
        
}
