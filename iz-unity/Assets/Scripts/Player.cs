using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private RaycastLefthand01 raycastLefthand;
    public const int MAXCOUNT = 5;
    public TextMeshProUGUI missionMessage;
    public TextMeshProUGUI findClue;
    public GameObject targetLocation;
    
    public string[] tags = { "tv", "bat", "dish", "bath", "diary" };
    public int life = 5;
    public int count = 0;

    void Start()
    {
        raycastLefthand = RaycastLefthand01.getInstance();
    }

    void changeMissionMessage()
    {
        this.missionMessage.text = "모든 단서를 찾았습니다.\n포탈을 통해 아이의 방으로\n이동해주세요.";
    }

    void changeFindClue()
    {
        this.findClue.text = "찾은 단서: " + this.count + " / " + MAXCOUNT;
    }

    void fakeClue(string tagName)
    {
        // 라이프 1 감소 및 text에 failMessage로 변경
        this.life--;
        // 라이프가 0이되면 아웃
        // TODO Add more
    }

    void realClue(string tagName)
    {
        // 카운트 1 증가 및 text에 successMessage로 변경
        GameObject gameObjectByTag = GameObject.FindGameObjectWithTag(tagName);
        //gameObjectByTag.transform.Find("")

        this.count++;
        changeFindClue();
        // 카운트가 MAX이면 missionMessage 변경, targetLocation 활성화
        if (this.count == MAXCOUNT)
        {
            changeMissionMessage();
            targetLocation.SetActive(true);
        }
    }

    public bool findCheck(string findTag)
    {
        print("태그: " + findTag);
        bool flag = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.tags[i] == findTag)
            {
                flag = true;
                break;
            }
        }
        raycastLefthand.addPicked(findTag);

        return flag;
    }

    public void clickClue(string findTag)
    {
        if (findCheck(findTag))
        {
            realClue(findTag);
        }
        else
        {
            fakeClue(findTag);
        }
    }
}
