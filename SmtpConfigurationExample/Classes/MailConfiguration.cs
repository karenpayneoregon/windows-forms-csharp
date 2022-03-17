using System;
using System.Configuration;
using System.IO;
using System.Net.Configuration;

namespace SmtpConfigurationExample.Classes
{
    public class MailConfiguration
    {
        private readonly SmtpSection _smtpSection;


        public MailConfiguration(string section = "system.net/mailSettings/smtp")
        {
            _smtpSection = (ConfigurationManager.GetSection(section) as SmtpSection);
        }

        public string FromAddress => _smtpSection.From;
        public string UserName => _smtpSection.Network.UserName;
        public string Password => _smtpSection.Network.Password;
        public bool DefaultCredentials => _smtpSection.Network.DefaultCredentials;
        public bool EnableSsl => _smtpSection.Network.EnableSsl;
        public string PickupFolder
        {
            get
            {
                var mailDrop = _smtpSection.SpecifiedPickupDirectory.PickupDirectoryLocation;

                if (mailDrop != null)
                {
                    mailDrop = Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        _smtpSection.SpecifiedPickupDirectory.PickupDirectoryLocation);
                }

                return mailDrop;
            }
        }
        /// <summary>
        /// Determine if pickup folder exists
        /// </summary>
        /// <returns></returns>
        public bool PickupFolderExists() => Directory.Exists(PickupFolder);

        /// <summary>
        /// Gets the name or IP address of the host used for SMTP transactions.
        /// </summary>
        public string Host => _smtpSection.Network.Host;

        /// <summary>
        /// Gets the port used for SMTP transactions
        /// </summary>
        public int Port => _smtpSection.Network.Port;

        /// <summary>
        /// Gets a value that specifies the amount of time after 
        /// which a synchronous Send call times out.
        /// </summary>
        public int TimeOut => 2000;
        public override string ToString() => $"From: [ {FromAddress} ]" +
                                             $"Host: [{Host}] Port: [{Port}] " +
                                             $"Pickup: {Directory.Exists(PickupFolder)}";
    }
}