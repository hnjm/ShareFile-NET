// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2018 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Client.Models 
{
	/// <summary>
	/// Outlook Information
	/// </summary>
	public class ToolInformation : ODataObject 
	{
		/// <summary>
		/// Tool Name
		/// </summary>
		public string ToolName { get; set; }
		/// <summary>
		/// Tool Version
		/// </summary>
		public string Version { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as ToolInformation;
			if(typedSource != null)
			{
				ToolName = typedSource.ToolName;
				Version = typedSource.Version;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("ToolName", out token) && token.Type != JTokenType.Null)
				{
					ToolName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Version", out token) && token.Type != JTokenType.Null)
				{
					Version = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}