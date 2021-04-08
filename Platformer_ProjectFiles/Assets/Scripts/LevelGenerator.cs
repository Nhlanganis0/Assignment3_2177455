using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform LevelPart_Start;
    [SerializeField] private List<Transform> LevelList;
    [SerializeField] PlayerController player;

    private const float PlayerDistance_from_NextLevel = 5;
    private Vector3 Last_EndPosition;

    private void Awake()
    {
        Last_EndPosition = LevelPart_Start.Find("EndPosition").position;

        int StartinSpawnLevel_Parts = 10;
        for(int i = 0; i < StartinSpawnLevel_Parts; i++)
        {
            SpawnNextLevelPart();
        }
    }

    void Update()
    {
        if (Vector3.Distance(player.GetPosition(), Last_EndPosition) < PlayerDistance_from_NextLevel)
        {
            SpawnNextLevelPart();
        }
    }

    public void SpawnNextLevelPart()
    {
        Transform selectedLevel = LevelList[Random.Range(0, LevelList.Count)];
        Transform lastLevel_Transform = SpawnNextLevel(selectedLevel, Last_EndPosition);
        Last_EndPosition = lastLevel_Transform.Find("EndPosition").position;
    }
    private Transform SpawnNextLevel(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPart_Transform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPart_Transform;
    }
    

}
