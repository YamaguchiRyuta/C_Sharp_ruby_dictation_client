using System;

namespace RubyDictation

public class PostNTE
{
    private Uri nteUrl;

    public PostNTE(Form1 form1)
    {
        this.form1 = form1;
    }

    public void SetUrl(Uri uri)
    {
        nteUrl = uri;
    }

    public void Send()
    {
        var json = "{ \"age\" : 20, \"name\" : \"太郎\"  }";
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(nteUrl, content);
    }

}
