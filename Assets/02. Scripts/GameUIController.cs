using UnityEngine;

public class GameUIController : MonoBehaviour
{

    public void OnClickBackButton()
    {
        // ���ξ��� ���Ӿ��� ���� �̵���ų �� ����
        //GameManager.Instance.ChangeToMainScene();

        GameManager.Instance.OpenConfirmPanel("������ �����Ͻðڽ��ϱ�?");
    }
}