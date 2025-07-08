using System.Net;

namespace RestAPIService;

public class RestAPIHelper : IRestAPIService
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

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<string> Post(string requestUrl, HttpContent requestBody)
    {
        string responseBody = string.Empty;
        HttpResponseMessage postResponse = await HttpClient.PostAsync(requestUrl, requestBody);

        if (postResponse.IsSuccessStatusCode)
            responseBody = await postResponse.Content.ReadAsStringAsync();
        else
            throw new Exception($"Status code: {postResponse.StatusCode}");

        return responseBody;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<string> Delete(string requestUrl)
    {
        string responseBody = string.Empty;
        HttpResponseMessage deleteResponse = await HttpClient.DeleteAsync(requestUrl);

        if (deleteResponse.IsSuccessStatusCode)
            responseBody = await deleteResponse.Content.ReadAsStringAsync();
        else
            throw new Exception($"Status code: {deleteResponse.StatusCode}");

        return responseBody;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<string> Put(string requestUrl, HttpContent requestBody)
    {
        string responseBody = string.Empty;
        HttpResponseMessage putResponse = await HttpClient.PutAsync(requestUrl, requestBody);

        if (putResponse.IsSuccessStatusCode)
            responseBody = await putResponse.Content.ReadAsStringAsync();
        else
            throw new Exception($"Status code: {putResponse.StatusCode}");

        return responseBody;
    }
}
