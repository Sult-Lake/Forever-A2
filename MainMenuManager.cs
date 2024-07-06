using UnityEngine;  
using UnityEngine.UI;  
using UnityEngine.SceneManagement;  
  
public class MainMenuManager : MonoBehaviour  
{  
    // 将这些字段拖动到Inspector面板中的相应按钮上  
    public Button startGameButton;  
    public Button exitGameButton;  
  
    void Start()  
    {  
        // 为按钮添加点击事件监听器  
        if (startGameButton != null)  
        {  
            startGameButton.onClick.AddListener(LoadGameScene);  
        }  
  
        if (exitGameButton != null)  
        {  
            exitGameButton.onClick.AddListener(QuitGame);  
        }  
    }  
  
    // 加载游戏场景的函数  
    public void LoadGameScene()  
    {  
        // 假设游戏场景在构建设置中的索引为1（你可以根据实际情况修改）  
        SceneManager.LoadScene(1);  
    }  
  
    // 退出游戏的函数  
    // 注意：Application.Quit()在编辑器中不会生效，只能在构建的游戏中测试  
    public void QuitGame()  
    {  
        Application.Quit();  
    }  
  
    // 如果你在PC上构建游戏，并且希望使用Escape键来退出游戏，可以添加以下代码  
    void Update()  
    {  
        if (Input.GetKeyDown(KeyCode.Escape))  
        {  
            QuitGame();  
        }  
    }  
}