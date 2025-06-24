namespace RestAPIService;

public interface IRestAPIHelper
{
    /// <summary>
    /// Отправить запрос Get
    /// </summary>
    /// <param name="requestUrl">URL запроса</param>
    /// <returns>Task<string></returns>
    Task<string> Get(string requestUrl);
}
