using TMPro;
using UnityEngine;

public class ConfirmPanelController : PanelController
{
    [SerializeField] private TMP_Text messageText;

    /// Confirm Panel을 표시하는 메서드
    public void Show(string message)
    {
        messageText.text = message;
        base.Show();
    }

    /// 확인 버튼 클릭시 호출되는 메서드
    public void OnClickConfirmButton()
    {
        Hide();
    }

    /// X 버튼  클릭시 호출되는 메서드
    public void OnClickCloseButton()
    {
        Hide();
    }
}