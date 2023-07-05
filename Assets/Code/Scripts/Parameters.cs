using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameters
{
    private Dictionary<string, char> charListData;
    private Dictionary<string, string> stringListData;

    private Dictionary<string, int> intListData;
    private Dictionary<string, float> floatListData;
    private Dictionary<string, short> shortListData;
    private Dictionary<string, long> longListData;
    private Dictionary<string, double> doubleListData;

    private Dictionary<string, bool> boolListData;

    private Dictionary<string, ArrayList> arrayListData;
    private Dictionary<string, object> objectListData;

    private Dictionary<string, Vector2> vector2ListData;
    private Dictionary<string, Vector3> vector3ListData;
    private Dictionary<string, Vector4> vector4ListData;
    private Dictionary<string, Quaternion> quaternionListData;

    //add Dictionaries
    public Parameters()
    {
    }

    public void PutInfo(string parameterName, char value)
    {
        charListData ??= new();
        charListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, string value)
    {
        stringListData ??= new();
        stringListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, int value)
    {
        intListData ??= new();
        intListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, float value)
    {
        floatListData ??= new();
        floatListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, short value)
    {
        shortListData ??= new();
        shortListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, long value)
    {
        longListData ??= new();
        longListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, double value)
    {
        doubleListData ??= new();
        doubleListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, bool value)
    {
        boolListData ??= new();
        boolListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, ArrayList value)
    {
        arrayListData ??= new();
        arrayListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, object value)
    {
        objectListData ??= new();
        objectListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, Vector2 value)
    {
        vector2ListData ??= new();
        vector2ListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, Vector3 value)
    {
        vector3ListData ??= new();
        vector3ListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, Vector4 value)
    {
        vector4ListData ??= new();
        vector4ListData.Add(parameterName, value);
    }

    public void PutInfo(string parameterName, Quaternion value)
    {
        quaternionListData ??= new();
        quaternionListData.Add(parameterName, value);
    }

    public char GetCharInfo(string parameterName, char defaultValue)
    {
        if (charListData.ContainsKey(parameterName))
            return charListData[parameterName];
        else
            return defaultValue;
    }

    public string GetStringInfo(string parameterName, string defaultValue)
    {
        if (stringListData.ContainsKey(parameterName))
            return stringListData[parameterName];
        else
            return defaultValue;
    }

    public int GetIntInfo(string parameterName, int defaultValue)
    {
        if (intListData.ContainsKey(parameterName))
            return intListData[parameterName];
        else
            return defaultValue;
    }

    public float GetFloatInfo(string parameterName, float defaultValue)
    {
        if(floatListData.ContainsKey(parameterName))
            return floatListData[parameterName];
        else
            return defaultValue;
    }

    public short GetShortInfo(string parameterName, short defaultValue)
    {
        if (shortListData.ContainsKey(parameterName))
            return shortListData[parameterName];
        else
            return defaultValue;
    }

    public long GetLongInfo(string parameterName, long defaultValue)
    {
        if (longListData.ContainsKey(parameterName))
            return longListData[parameterName];
        else
            return defaultValue;
    }

    public double GetDoubleInfo(string parameterName, double defaultValue)
    {
        if (doubleListData.ContainsKey(parameterName))
            return doubleListData[parameterName];
        else
            return defaultValue;
    }

    public ArrayList GetShortInfo(string parameterName)
    {
        if (arrayListData.ContainsKey(parameterName))
            return arrayListData[parameterName];
        else
            return null;
    }

    public object GetObjectInfo(string parameterName)
    {
        if (objectListData.ContainsKey(parameterName))
            return objectListData[parameterName];
        else
            return null;
    }

    public Vector2 GetVector2Info(string parameterName, Vector2 defaultValue)
    {
        if (vector2ListData.ContainsKey(parameterName))
            return vector2ListData[parameterName];
        else
            return defaultValue;
    }

    public Vector3 GetVector3Info(string parameterName, Vector3 defaultValue)
    {
        if (vector3ListData.ContainsKey(parameterName))
            return vector3ListData[parameterName];
        else
            return defaultValue;
    }

    public Vector4 GetVector4Info(string parameterName, Vector4 defaultValue)
    {
        if (vector4ListData.ContainsKey(parameterName))
            return vector4ListData[parameterName];
        else
            return defaultValue;
    }

    public Quaternion GetQuaternionInfo(string parameterName, Quaternion defaultValue)
    {
        if (quaternionListData.ContainsKey(parameterName))
            return quaternionListData[parameterName];
        else
            return defaultValue;
    }
}
