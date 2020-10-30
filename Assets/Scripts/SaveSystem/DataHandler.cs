using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class DataHandler : MonoBehaviour
{
    private string path;
    private string jsonObj;

    public void Save<T>(string _file, T _object)
    {
        path = Application.streamingAssetsPath + @"\" + _file + ".json";


        jsonObj = JsonUtility.ToJson(_object);
        File.WriteAllText(path, jsonObj);
    }

    public T Load<T>(string _file)
    {
        path = Application.streamingAssetsPath + @"\" + _file + ".json";
        jsonObj = File.ReadAllText(path);
        
        T data = JsonUtility.FromJson<T>(jsonObj);

        return data;
    }

}
