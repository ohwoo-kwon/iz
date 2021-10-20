using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpecialObjectHandler : MonoBehaviour
{
    public GameObject ParentToBotherAbout;

    public string[] GameObjectContainersToDisable;
    private GameObjectsContainer[] gameObjectsContainers;
    private GameObjectsContainer gameObjectsContainer;
    public GameObject[] ObjectsToKeepActive;
    public SpecialObjectHandler()
	{
	}
    void Start()
    {
        gameObjectsContainers = GetComponentsInParent<GameObjectsContainer>();
    }
    void OnGUI()
    {

        for (int i = 0; i < gameObjectsContainers.Length; i++)
        {
            gameObjectsContainer = gameObjectsContainers[i];
            for (int a = 0; a < GameObjectContainersToDisable.Length; a++)
            {
                if (gameObjectsContainer.ContainerName == GameObjectContainersToDisable[a])
                {
                    for (int b = 0; b < gameObjectsContainer.GameObjects.Length; b++)
                    {

                        if (gameObjectsContainer.GameObjects[b] != null)
                        {
                            gameObjectsContainer.GameObjects[b].SetActive(false);
                        }
                    }
                }
            }
        }
        for (int c = 0; c < ObjectsToKeepActive.Length; c++)
        {
            if (ObjectsToKeepActive[c] != null)
            {
                ObjectsToKeepActive[c].SetActive(true);
            }
        }
    }
    void OnDisable()
    {
        for (int a = 0; a < GameObjectContainersToDisable.Length; a++)
        {
            for (int i = 0; i < gameObjectsContainers.Length; i++)
            {
                gameObjectsContainer = gameObjectsContainers[i];
                if (gameObjectsContainer.ContainerName == GameObjectContainersToDisable[a])
                {
                    if (gameObjectsContainer.GameObjects[gameObjectsContainer.ObjectSelected] != null)
                    {
                        gameObjectsContainer.GameObjects[gameObjectsContainer.ObjectSelected].SetActive(true);
                    }
                }
            }
        }
    }
}
