using UnityEngine;

public class GameUIController : MonoBehaviour
{

    public void OnClickBackButton()
    {
        // 메인씬과 게임씬을 서로 이동시킬 수 있음
        //GameManager.Instance.ChangeToMainScene();

        GameManager.Instance.OpenConfirmPanel("게임을 종료하시겠습니까?");
    }
}