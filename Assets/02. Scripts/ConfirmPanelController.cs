using TMPro;
using UnityEngine;

public class ConfirmPanelController : PanelController
{
    [SerializeField] private TMP_Text messageText;

    /// Confirm Panel�� ǥ���ϴ� �޼���
    public void Show(string message)
    {
        messageText.text = message;
        base.Show();
    }

    /// Ȯ�� ��ư Ŭ���� ȣ��Ǵ� �޼���
    public void OnClickConfirmButton()
    {
        Hide();
    }

    /// X ��ư  Ŭ���� ȣ��Ǵ� �޼���
    public void OnClickCloseButton()
    {
        Hide();
    }
}