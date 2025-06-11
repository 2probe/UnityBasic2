using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Renpy : MonoBehaviour
{
    [SerializeField] Image img_BG; //배경
    [SerializeField] Image[] Char; //캐릭터


    [SerializeField] TextMeshProUGUI Txt_Name;
    [SerializeField] TextMeshProUGUI Txt_NameTag;
    [SerializeField] TextMeshProUGUI Txt_Text;

    int id = 1;


    void Start()
    {
        int characterID = SData.GetDialogueData(id).Character;

        Txt_Name.text = SData.GetCharacterData(characterID).Name;
        Txt_NameTag.text = SData.GetCharacterData(characterID).Title;

        Txt_Text.text = SData.GetDialogueData(id).Dialogue;

    }

    public void OnClickButton()
    {
        id++;

        int characterID = SData.GetDialogueData(id).Character;

        Txt_Name.text = SData.GetCharacterData(characterID).Name;
        Txt_NameTag.text = SData.GetCharacterData(characterID).Title;

        Txt_Text.text = SData.GetDialogueData(id).Dialogue;
    }

    void RefreshUI()
    {
        int characterID = SData.GetDialogueData(id).Character;
        Txt_Name.text = SData.GetCharacterData(characterID).Name;
        Txt_NameTag.text = SData.GetCharacterData(characterID).Title;
        Txt_Text.text = SData.GetDialogueData(id).Dialogue;

        img_BG.sprite = Resources.Load<Sprite>("Img/Renpy/" + SData.GetDialogueData(id).BG); // 배경 이미지 설정









    }
}
