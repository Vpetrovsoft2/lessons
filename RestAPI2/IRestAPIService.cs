namespace RestAPIService;

public interface IRestAPIService
{
    /// <summary>
    /// Отправить запрос Get
    /// </summary>
    /// <param name="requestUrl">URL запроса</param>
    /// <returns>Task<string></returns>
    Task<string> Get(string requestUrl);

    /// <summary>
    /// Отпвить запрос Post
    /// </summary>
    /// <param name="requestUrl">URL запроса</param>
    /// <param name="requestBody">Тело запроса</param>
    /// <returns>Task<string></returns>
    Task<string> Post(string requestUrl, HttpContent requestBody);

    /// <summary>
    /// Отправить запрос Delete
    /// </summary>
    /// <param name="requestUrl">URL запроса</param>
    /// <returns>Task<string></returns>
    Task<string> Delete(string requestUrl);

    /// <summary>
    /// Отправить запрос Put
    /// </summary>
    /// <param name="requestUrl">URL запроса</param>
    /// <param name="requestBody">Тело запроса</param>
    /// <returns>Task<string></returns>
    Task<string> Put(string requestUrl, HttpContent requestBody);
}
