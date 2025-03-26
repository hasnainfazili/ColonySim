using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MenuCardManager : MonoBehaviour
{
    public GameObject MenuCardGO;
    public GameObject WorkersMenuCardGO;
    public TextMeshProUGUI cardTitleText;
    public TextMeshProUGUI cardDescriptionText;
    public Image cardSprite;

    public void OnEnable()
    {
        EventManager.Instance.MenuCardEvents.OnResourcePointClicked += UpdateResourcePoint ;
    }
    //OnClick Update the MenuCard using unity Events since it will be reusable
    
    private void UpdateResourcePoint(ResourcePointScriptable resourcePoint)
    {
        if (MenuCardGO.activeInHierarchy)
        {
            MenuCardGO.SetActive(false);
        }
        MenuCardGO.SetActive(true);
        cardTitleText.text = resourcePoint.pointName;
        cardDescriptionText.text = resourcePoint.pointDescription;
        cardSprite.sprite = resourcePoint.pointSprite;
        //Create a List for all the workers on the resource point 
    }
    
}