using System;
using System.Configuration;
using System.IO;
using System.Net.Configuration;

namespace SmtpConfigurationExample.Classes
{
    public class MailConfiguration
    {
        private readonly SmtpSection _smtpSection;

        /// <summary>
        /// Configure which setting to use for getting SMTP settings 
        /// from the configuration file.
        /// </summary>
        /// <param name="section"></param>
        public MailConfiguration(string section = "system.net/mailSettings/smtp")
        {
            _smtpSection = (ConfigurationManager.GetSection(section) as SmtpSection);
        }

        /// <summary>
        /// Email address for the system
        /// </summary>
        public string FromAddress => _smtpSection.From;

        #region Should be encrypted (will show how in part 2 of this series)
        public string UserName => _smtpSection.Network.UserName;
        public string Password => _smtpSection.Network.Password;
        #endregion
        /// <summary>
        /// Gets the system credentials of the application.
        /// </summary>
        public bool DefaultCredentials => _smtpSection.Network.DefaultCredentials;
        /// <summary>
        /// Specify whether the SmtpClient uses Secure Sockets Layer (SSL) 
        /// to encrypt the connection.
        /// </summary>
        public bool EnableSsl => _smtpSection.Network.EnableSsl;
        /// <summary>
        /// Gets or sets the folder where applications save mail messages to 
        /// be processed by the local SMTP server.
        /// </summary>
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
        public bool PickupFolderExists()
        {
            return Directory.Exists(PickupFolder);
        }
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

        /// <summary>
        /// Allows, for debugging to review from address, host and port properties
        /// </summary>
        /// <returns>A string with main properties</returns>
        public override string ToString() => $"From: [ {FromAddress} ]" +
                                             $"Host: [{Host}] Port: [{Port}] " +
                                             $"Pickup: {Directory.Exists(PickupFolder)}";
    }
}