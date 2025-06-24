namespace RestAPIService;

public class RestAPIHelper
{
    private HttpClient HttpClient => new();

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<string> Get(string requestUrl)
    {
        string responseBody = string.Empty;
        HttpResponseMessage getResponse = await HttpClient.GetAsync(requestUrl);

        if (getResponse.IsSuccessStatusCode)
            responseBody = await getResponse.Content.ReadAsStringAsync();
        else
            throw new Exception($"Status code: {getResponse.StatusCode}");

        return responseBody;
    }
}
