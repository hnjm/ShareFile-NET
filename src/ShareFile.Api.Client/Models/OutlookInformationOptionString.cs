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
	/// OutlookInformationOptionString
	/// </summary>
	public class OutlookInformationOptionString : ODataObject 
	{
		/// <summary>
		/// Setting is locked.
		/// </summary>
		public bool Locked { get; set; }
		/// <summary>
		/// Value
		/// </summary>
		public string Value { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as OutlookInformationOptionString;
			if(typedSource != null)
			{
				Locked = typedSource.Locked;
				Value = typedSource.Value;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Locked", out token) && token.Type != JTokenType.Null)
				{
					Locked = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("Value", out token) && token.Type != JTokenType.Null)
				{
					Value = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}