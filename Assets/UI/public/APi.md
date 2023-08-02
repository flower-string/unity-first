使用时需要将UIManager预制体拖入场景中，UIManager包含了一个画布，将场景的摄像机赋值给画布的摄像机覆盖属性。

下面时若干对画布进行操作的方法

## 面板

### 应用示例

下面的类使用方法一样。

1. 在脚本中定义一个对应类型的变量，访问权限为public ，例如使用NpcManager，则需要

~~~c#
public NpcManager nm;
~~~

2. 在unity编辑器中将UIManager对象赋值给上一步定义的变量
3. 调用需要的方法

~~~c#
nm.ShowBox();
~~~



### NpcManager     答题面板

1. `void SetQuestion(string)` 设置问题中的文字
2. `void SetButton(string[])`  设置回答的按钮
3. `void ShowBox()`   显示npc面板
4. `void HideBox()`   隐藏Npc面板



### NoteManager    知识点面板

1. `void CloseNote() `   关闭知识点面板
2. `void ShowNote()`    显示答题面板
3. `void SetTitle(string)`    设置知识点标题
4. `void SetContent(string)`  设置知识点内容



### TipsManager   提示信息面板

1. `void ShowTips() `  显示提示信息面板

2. `void CloseTips()`    关闭提示信息面板
3. `void SetTips(string) `    设置提示信息

### FileManager

网上查不到如何动态修改UI结构的教程，暂时先放一下

#### ResultManager  闯关结果面板

##### 方法

1. `void Success(); ` 通关时调用
2. `void Fail();`         失败时调用
3. `CloseBox();  `       关闭面板

4. `SetTitle(); `            设置关卡名

 


## 静态类

### ArticleManager

#### 应用示例

~~~c#
Article a = ArticleManager.GetRandomArticle();
string title = a.title;
string content = a.content;
ArticleManager.articles
~~~



#### 静态属性

1. `articles`           所有的知识点对象组成的列表，每一项包含标题和内容
2. `readArticles`    获得过的知识点对象
3. `unreadArticles`   未获得的知识点对象

#### 静态方法

1. `Article GetRandomArticle() `  获取随机的知识点
2. `Article GetRandomReadArticle()`   返回随机一个获得过的知识点
3. `Article GetRandomUnreadArticle()`    返回随机一个未获得过的知识点





## 更新1

### Router    

使用方法与上面的面板相同，已经实现按下R键后打开该面板。

1. `void OpenBox();`    打开面板
2. `void CloseBox(); `    关闭面板
3. `void push(string)；`         切换到指定的场景
4. `void Pause();`                     暂停游戏并打开面板
5. `void Play();  `                     继续游戏并关闭面板
6. `void Reload();  `                   重新加载场景    



### NpcManager  

增加了设置答案的方法，必须先调用设置答案，否则无法设置问题和选项

1. `SetAnswer(string)  `  ,需要传入大写的A、B、C、D字符串，传入其他值无效。