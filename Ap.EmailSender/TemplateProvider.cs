using System;
using System.Collections.Generic;
using System.Linq;

namespace Ap.EmailSender
{
    public class TemplateProvider : ITemplateProvider
    {
        readonly IEnumerable<EmailTemplate> _templates;

        public TemplateProvider(IEnumerable<EmailTemplate> templates)
        {
            _templates = templates;
        }

        public string GetTemplateFor<T>(T model)
        {
            var emailTemplate = _templates.FirstOrDefault(x => x.ForType == model.GetType());

            if (emailTemplate == null)
                throw new ArgumentException(String.Format("No template available for model type '{0}'.", model.GetType()));

            return emailTemplate.Template;
        }

    }
}