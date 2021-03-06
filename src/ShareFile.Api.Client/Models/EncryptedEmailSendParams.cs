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
	/// EncryptedEmail Send Parameters
	/// </summary>
	public class EncryptedEmailSendParams : ODataObject 
	{
		/// <summary>
		/// Item for a plain text file that will serve as the message body
		/// </summary>
		public Item Message { get; set; }
		/// <summary>
		/// Items that will be attached to the Email
		/// </summary>
		public IEnumerable<Item> Attachments { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as EncryptedEmailSendParams;
			if(typedSource != null)
			{
				Message = typedSource.Message;
				Attachments = typedSource.Attachments;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Message", out token) && token.Type != JTokenType.Null)
				{
					Message = (Item)serializer.Deserialize(token.CreateReader(), typeof(Item));
				}
				if(source.TryGetProperty("Attachments", out token) && token.Type != JTokenType.Null)
				{
					Attachments = (IEnumerable<Item>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<Item>));
				}
			}
		}
	}
}