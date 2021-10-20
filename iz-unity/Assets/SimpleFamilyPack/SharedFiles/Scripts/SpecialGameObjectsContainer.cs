using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpecialGameObjectsContainer : MonoBehaviour
{
    public GameObject GameObjectToFuzz;
    public string[] GameObjectContainersToDisable;
    public GameObject[] ObjectsToKeepActive;
    public SpecialGameObjectsContainer()
	{
	}
    void Start()
    {

        SpecialObjectHandler sc = GameObjectToFuzz.AddComponent(typeof(SpecialObjectHandler)) as SpecialObjectHandler;
        sc.ParentToBotherAbout = GameObjectToFuzz;
        sc.GameObjectContainersToDisable = GameObjectContainersToDisable;
        sc.ObjectsToKeepActive = ObjectsToKeepActive;
    }
}
