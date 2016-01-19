﻿using System.ComponentModel;
using Newtonsoft.Json;
using Roadkill.Core.Security;

namespace Roadkill.Core.Configuration
{
	/// <summary>
	/// Describes all configurable settings stored in a config file that are used by roadkill.
	/// </summary>
	public interface IRoadkillConfiguration
	{
		/// <summary>
		/// Gets or sets the name of the admin role.
		/// </summary>
		string AdminRoleName { get; set; }

		/// <summary>
		/// Gets or sets the api keys (comma seperated) used for access to the REST api. If this is empty, then the REST api is disabled.
		/// </summary>
		string ApiKeys { get; set; }

		/// <summary>
		/// The database connection string.
		/// </summary>
		string ConnectionString { get; set; }

		/// <summary>
		/// Gets or sets the name of the editor role.
		/// </summary>
		string EditorRoleName { get; set; }

		/// <summary>
		/// Gets or sets whether this roadkill instance has been installed.
		/// </summary>
		bool Installed { get; set; }

		/// <summary>
		/// Whether to enabled Windows and Active Directory authentication.
		/// </summary>
		bool UseWindowsAuthentication { get; set; }

		#region Optional properties
		/// <summary>
		/// Whether errors in updating the lucene index throw exceptions or are just ignored.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue(true)]
		bool? IgnoreSearchIndexErrors { get; set; }

		/// <summary>
		/// Gets or sets the attachments folder, which should begin with "~/".
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue("~/App_Data/Attachments")]
		string AttachmentsFolder { get; set; }

		/// <summary>
		/// TODO: comments
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue("Attachments")]
		string AttachmentsRoutePath { get; set; }

		/// <summary>
		/// The database type for Roadkill. This defaults to SQLServer2008 (MongoDB on Mono) if empty.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue("SqlServer2008")]
		string DatabaseName { get; set; }

		/// <summary>
		/// Whether the site is public, i.e. all pages are visible by default. The default is true, and this is optional.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue(true)]
		bool? IsPublicSite { get; set; }

		/// <summary>
		/// For example: LDAP://mydc01.company.internal
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue("")]
		string LdapConnectionString { get; set; }

		/// <summary>
		/// The username to authenticate against the AD with
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue("")]
		string LdapUsername { get; set; }

		/// <summary>
		/// The password to authenticate against the AD with
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue("")]
		string LdapPassword { get; set; }

		/// <summary>
		/// Whether to remove all HTML tags from the markup except those found in the whitelist.xml file,
		/// inside the App_Data folder.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue(true)]
		bool? UseHtmlWhiteList { get; set; }

		/// <summary>
		/// Indicates whether server-based page object caching is enabled.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue(true)]
		bool? UseObjectCache { get; set; }

		/// <summary>
		/// Indicates whether page content should be cached, if <see cref="UseObjectCache"/> is true.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue(true)]
		bool? UseBrowserCache { get; set; }

		/// <summary>
		/// The type used for the managing users, in the format "MyNamespace.Type".
		/// This class should inherit from the <see cref="UserServiceBase"/> class or a one of its derived types.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue("")]
		string UserServiceType { get; set; }

		/// <summary>
		/// TODO: comments + tests
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue("")]
		bool? UseAzureFileStorage { get; set; }

		/// <summary>
		/// TODO: comments + tests
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue("")]
		string AzureConnectionString { get; set; }

		/// <summary>
		/// TODO: comments + tests
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		[DefaultValue("")]
		string AzureContainer { get; set; }
		#endregion
	}
}