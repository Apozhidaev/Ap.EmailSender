namespace Ap.EmailSender
{
    public interface ITemplateProvider
    {
        string GetTemplateFor<T>(T model);
    }
}