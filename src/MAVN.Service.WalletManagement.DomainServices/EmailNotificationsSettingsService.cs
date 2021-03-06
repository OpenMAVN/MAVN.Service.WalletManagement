﻿using MAVN.Service.WalletManagement.Domain.Models;
using MAVN.Service.WalletManagement.Domain.Services;

namespace MAVN.Service.WalletManagement.DomainServices
{
    public class  EmailNotificationsSettingsService : IEmailNotificationsSettingsService
    {
        public EmailNotificationsSettingsService(EmailTemplateSettings p2PSuccessForSenderTemplateSettings,
            EmailTemplateSettings p2PSuccessForReceiverTemplateSettings,
            EmailTemplateSettings p2PFailureForSenderTemplateSettings)
        {
            P2PSuccessForSenderTemplateSettings = p2PSuccessForSenderTemplateSettings;
            P2PSuccessForReceiverTemplateSettings = p2PSuccessForReceiverTemplateSettings;
            P2PFailureForSenderTemplateSettings = p2PFailureForSenderTemplateSettings;
        }
        public EmailTemplateSettings P2PSuccessForSenderTemplateSettings { get; }
        public EmailTemplateSettings P2PSuccessForReceiverTemplateSettings { get; }
        public EmailTemplateSettings P2PFailureForSenderTemplateSettings { get; }
    }
}
