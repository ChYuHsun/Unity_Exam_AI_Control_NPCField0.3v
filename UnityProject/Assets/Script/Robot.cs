using UnityEngine;

public class Robot : MonoBehaviour {


    /// <summary>
    /// 任務對話
    /// </summary>
    [Header("對話")]
    public string Say = "還不快給我拿螺絲來 ";
    public string ComMission = "沒想到你還挺能幹的 ";
    public string NoComPMission = "連個螺絲都沒拿過來, 給我打掉重練 ";
    public float SaySpeed;

    /// <summary>
    /// 任務相關
    /// </summary>
    [Header("任務條件")]
    public bool 是否完成任務;
    public int 總需求數量;
    public int 已達成數量;

}
