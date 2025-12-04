namespace Microsoft.Extensions.AI;

/// <summary>
/// doc_url类型
/// </summary>
public class DocUrlContent : AIContent
{

    public DocUrlContent(string text,string[] urls)
    {
        this.Text = text;
        this.DocUrl = urls;
    }

    /// <summary>
    /// 消息类容
    /// </summary>
    public string Text { get; private set; }

    /// <summary>
    /// 文件uri集合
    /// </summary>
    public string[] DocUrl { get; private set; }
}
