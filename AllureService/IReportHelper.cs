namespace AllureService
{
    public interface IReportHelper
    {
        /// <summary>
        /// Отдельный шаг отчёта, в случае падения тест завершится
        /// </summary>
        /// <param name="name">Текст шага</param>
        /// <param name="action">Событие</param>
        void RunStep(string name, Action action);

        /// <summary>
        /// Отдельный шаг отчёта, в случае падения тест завершится (Дженерик)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">Текст шага</param>
        /// <param name="func">Событие</param>
        /// <returns></returns>
        T RunStep<T>(string name, Func<T> func);

        /// <summary>
        /// Отдельный шаг отчёта с ворнингом и тест не упадёт
        /// </summary>
        /// <param name="name">Текст шага</param>
        /// <param name="action">Событие</param>
        void TryRunStep(string name, Action action);

        /// <summary>
        /// Вывести ошибку в шаге отчёта
        /// </summary>
        /// <param name="titleStep">Описание шага</param>
        /// <param name="errorMessage">Текст ошибки</param>
        /// <param name="fatalError">true - если ошибка критичная и тест завершится, иначе false</param>
        void ErrorMessageInNewStep(string titleStep, string? errorMessage = null, bool fatalError = false);

        /// <summary>
        /// Вывести сообщение в шаге отчёта
        /// </summary>
        /// <param name="titleStep">Описание шага</param>
        void MessageInNewStep(string titleStep);
    }
}
