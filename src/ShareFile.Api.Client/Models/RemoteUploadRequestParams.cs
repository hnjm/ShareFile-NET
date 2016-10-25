// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2016 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Models 
{
	public class RemoteUploadRequestParams : UploadRequestParams 
	{

		public Contact Creator { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as RemoteUploadRequestParams;
			if(typedSource != null)
			{
				Creator = typedSource.Creator;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Creator", out token) && token.Type != JTokenType.Null)
				{
					Creator = (Contact)serializer.Deserialize(token.CreateReader(), typeof(Contact));
				}
			}
		}
	}
}