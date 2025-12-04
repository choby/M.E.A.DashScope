## 本项目为Cnblogs.DashScope.Sdk针对Microsoft.Extesions.AI的扩展
项目中需要安装Cnblogs.DashScope.Sdk
本包和Cnblogs.DashScope.AI互斥,不要同时安装
## 用法
- 安装本包
`dotnet add package M.E.A.DashScope --version 1.0.0`
- 创建消息
```csharp
        var messages = new List<ChatMessage>
        {
            new ChatMessage(ChatRole.System, """你是一个简历信息提取助手，请从用户提供的简历文件中提取信息"""),
            new ChatMessage(ChatRole.User, new List<AIContent>()
            {
                new TextContent("""
                                把简历中的信息提取为 json 格式,并返回
                                """),
                new DocUrlContent(["https://ssss.ddd.pdf"])
            }),
        };

        var response = await _chatClient.GetResponseAsync(messages, new ChatOptions()
        {
            ResponseFormat = ChatResponseFormat.Json
        });
```
