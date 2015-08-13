/// <summary>
/// 比较独立的枚举置于此处，反之则置于类内部
/// </summary>
using strange.extensions.signal.impl;
public class GameConfig
{
    //public enum CoreEvent
    //{
    //    GAME_START,
    //    /// <summary>
    //    /// 操作控制可以使用Update
    //    /// </summary>
    //    GAME_UPDATE,
    //    /// <summary>
    //    /// 如果是物理计算请使用FixedUpdate
    //    /// </summary>
    //    GAME_FIXEDDATE,
    //    /// <summary>
    //    /// 游戏结束调用 如：玩家失败
    //    /// </summary>
    //    GAME_OVER,
    //    /// <summary>
    //    /// 游戏重置
    //    /// </summary>
    //    GAME_RESET,
    //    /// <summary>
    //    /// 暂空
    //    /// </summary>
    //    USER_TOUCH,
    //    /// <summary>
    //    /// 调用过场
    //    /// </summary>
    //    LOADING_FIGHTING,
    //    /// <summary>
    //    /// 游戏暂停
    //    /// </summary>
    //    GAME_PAUSE,
    //    /// <summary>
    //    /// 游戏退出
    //    /// </summary>
    //    GAME_EXIT
    //}
}

//对应枚举转为全局Signal

public class AppStartSignal : Signal { }
public class AppExitSignal : Signal { }
public class GameStartSignal : Signal { }
/// <summary>
/// 游戏重置
/// </summary>
public class GameOverSignal : Signal { }
/// <summary>
/// 游戏暂停
/// </summary>
public class GamePauseSignal : Signal { }
/// <summary>
/// 游戏重置
/// </summary>
public class GameResetSignal : Signal { }
public class GameFixUpdateSignal : Signal { }
public class GameUpdateSignal : Signal { }
/// <summary>
/// 调用过场
/// </summary>
public class LoadingSignal : Signal { }
/// <summary>
/// 初始化逻辑数据 
/// </summary>
public class InitDataSignal : Signal { }
/// <summary>
/// 测试01
/// </summary>
public class Test01Signal : Signal<string,int> { }
