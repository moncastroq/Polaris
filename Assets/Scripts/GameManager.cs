﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using LitJson;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private SaveData curSaveData;

    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        Initialize();
    }

    public void Initialize()
    {
        var constelRaw = Resources.Load<TextAsset>("Data/Constels");
        var constelGroup = JsonMapper.ToObject(constelRaw.text);

        Variables.Constels = new Dictionary<string, ConstelData>();
        foreach (JsonData data in constelGroup["constels"])
        {
            var newConstel = new ConstelData((string)data["key"], (string)data["name"]);
            Variables.Constels.Add(newConstel.InternalName, newConstel);
        }
    }

    #region Game Data Save/Load
    public void CreateGame()
    {
        curSaveData = new SaveData();
        curSaveData.Create();
    }

    public void LoadGame()
    {
        var reader = new FileStream(Application.persistentDataPath + "/save", FileMode.Open);
        var formatter = new BinaryFormatter();
        curSaveData = (SaveData)formatter.Deserialize(reader);
        reader.Close();

        curSaveData.Load();
    }

    public void SaveGame()
    {
        curSaveData.Save();

        var writer = new FileStream(Application.persistentDataPath + "/save", FileMode.Create);
        var formatter = new BinaryFormatter();
        formatter.Serialize(writer, curSaveData);
        writer.Close();
    }

    // FOR DEBUG PURPOSE ONLY
    public void DeleteGame()
    {
        curSaveData = null;
        File.Delete(Application.persistentDataPath + "/save");
    }
    #endregion

    /// <summary>
    /// 친밀도를 체크하는 함수입니다.
    /// 직접적으로는 친밀도 레벨을 반환하며 (1 ~ 6), 간접적으로 현재 친밀도 진행 정도와 다음 레벨까지의 요구 친밀도를 반환합니다.
    /// </summary>
    /// <param name="charNumber">캐릭터 번호입니다.</param>
    /// <param name="cardIndex">캐릭터 내부 인덱스입니다. (Cards 배열)</param>
    /// <param name="progress"></param>
    /// <param name="required"></param>
    /// <returns></returns>
    public int CheckFavority(int charNumber, int cardIndex, out int progress, out int required)
    {
        var favority = Variables.Characters[charNumber].Cards[cardIndex].Favority;
        int cnt = 0;
        for (; cnt < Variables.FavorityThreshold.Length; cnt++)
        {
            if (favority < Variables.FavorityThreshold[cnt])
                break;
        }
        if(cnt >= Variables.FavorityThreshold.Length)
        {
            progress = 0;
            required = 0;
        }
        else
        {
            progress = favority - (cnt > 0 ? Variables.FavorityThreshold[cnt - 1] : 0);
            required = Variables.FavorityThreshold[cnt] - (cnt > 0 ? Variables.FavorityThreshold[cnt - 1] : 0);
        }
        return cnt + 1;
    }
}